using System.Collections.Generic;
using System.Linq;
using Assets.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public List<Card> deck1 = new();
	public List<Card> deck2 = new();
	public List<Card> deck3 = new();
	public List<Card> nobleDeck = new();
	public List<Token> GreenTokens = new();
	public List<Token> BlackTokens = new();
	public List<Token> BlueTokens = new();
	public List<Token> RedTokens = new();
	public List<Token> WhiteTokens = new();
	public List<Token> GoldTokens = new();
	
	public float Offset;
	
	public TMP_Text PlayerTurn;
	public TMP_Text Points;
	public TMP_Text GreenCards;
	public TMP_Text BlackCards;
	public TMP_Text BlueCards;
	public TMP_Text RedCards;
	public TMP_Text WhiteCards;

	public Transform greenTokenSlot;
	public Transform blackTokenSlot;
	public Transform blueTokenSlot;
	public Transform redTokenSlot;
	public Transform whiteTokenSlot;
	public Transform goldTokenSlot;
	public float GreenOffset = 0;
	public float BlackOffset = 0;
	public float BlueOffset = 0;
	public float RedOffset = 0;
	public float WhiteOffset = 0;
	public float GoldOffset = 0;

	public Transform[] cardSlots = new Transform[12];
	public Transform[] nobleCardSlots = new Transform[5];
	public bool[] availableCardSlotsDeck1;
	public bool[] availableCardSlotsDeck2;
	public bool[] availableCardSlotsDeck3;

	public Player player1;
	public Player player2;
	public Player player3;
	public Player player4;
	public Player potentialWinner;

	public static List<Player> players = new();

    public GameObject QuitPanel;
	public GameObject EndGamePanel;
	public TMP_Text FirstPlace;
	public TMP_Text SecondPlace;
	public TMP_Text ThirdPlace;

	private void Start()
	{
		//Shuffle the decks
		deck1 = Shuffle(deck1);
		deck2 = Shuffle(deck2);
		deck3 = Shuffle(deck3);
		nobleDeck = Shuffle(nobleDeck);

		ChangeRulesAccordingToNumberOfPlayers();
		DrawInitialCards();
		PutTokensInPositions();
		StartGame();
	}

	private void StartGame()
	{
		foreach (var t in players.Where(t => t.gameObject.activeSelf))
		{
			t.IsTurn = true;
			return;
		}
	}

	public void EndTurn()
	{
		GetPlayer().firstToken = null;
		GetPlayer().secondToken = null;
		GetPlayer().thirdToken = null;
		GetPlayer().PlayedCard = false;
		GetPlayer().TookTokens = false;
		if (GetPlayer().Points >= 15)
		{
			BeginLastTurn();
		}
		NextPlayer(GetPlayer());
	}

	private void BeginLastTurn()
	{
		GetPlayer().isPotentialWinner = true;
	}

	private void EndGame()
    {
		List<Player> sortedPlayers = players.OrderByDescending(x => x.Points).ToList();
		// Remove current tables
		foreach (Player player in players)
			player.PlayerTable.SetActive(false);

		EndGamePanel.gameObject.SetActive(true);
		FirstPlace.text += sortedPlayers[0].Name + " (" + sortedPlayers[0].Points +  " points)";
		SecondPlace.text += sortedPlayers[1].Name + " (" + sortedPlayers[1].Points + " points)";
		ThirdPlace.text += sortedPlayers[2].Name + " (" + sortedPlayers[2].Points + " points)";
	}

	private void Update()
	{
		PlayerTurn.text = GetPlayer().Name + "'s Turn";
		Points.text = "Current points: " + GetPlayer().Points;
		BlackCards.text = GetPlayer().BlackCards + " Black cards";
		GreenCards.text = GetPlayer().GreenCards + " Green cards";
		WhiteCards.text = GetPlayer().WhiteCards + " White cards";
		RedCards.text = GetPlayer().RedCards + " Red cards";
		BlueCards.text = GetPlayer().BlueCards + " Blue cards";

		if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitPanel.gameObject.SetActive(!QuitPanel.gameObject.activeSelf);
        }
	}

    public void Quit()
    {
		Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

    public List<Card> Shuffle(List<Card> deck)
	{
		List<Card> shuffledDeck = new List<Card>();
		while (deck.Count > 0)
		{
			var randomIndex = Random.Range(0, deck.Count);
			shuffledDeck.Add(deck[randomIndex]);
			deck.RemoveAt(randomIndex);
		}

		return shuffledDeck;
	}

	private void ChangeRulesAccordingToNumberOfPlayers()
	{
		if (OptionsMenu.Player1Active)
		{
			player1.gameObject.SetActive(true);
			player1.Name = OptionsMenu.Player1Name;
			players.Add(player1);
			player1.PlayerTable.gameObject.SetActive(true);
			player1.PlayerNameTableText.gameObject.SetActive(true);
			player1.PlayerNameTableText.text = player1.Name;
		}

		if (OptionsMenu.Player2Active)
		{
			player2.gameObject.SetActive(true);
			player2.Name = OptionsMenu.Player2Name;
			players.Add(player2);
			player2.PlayerTable.gameObject.SetActive(true);
			player2.PlayerNameTableText.gameObject.SetActive(true);
			player2.PlayerNameTableText.text = player2.Name;			
		}

		if (OptionsMenu.Player3Active)
		{
			player3.gameObject.SetActive(true);
			player3.Name = OptionsMenu.Player3Name;
			players.Add(player3);
			player3.PlayerTable.gameObject.SetActive(true);
			player3.PlayerNameTableText.gameObject.SetActive(true);
			player3.PlayerNameTableText.text = player3.Name;
		}
		if (OptionsMenu.Player4Active)
		{
			player4.gameObject.SetActive(true);
			player4.Name = OptionsMenu.Player4Name;
			players.Add(player4);
			player4.PlayerTable.gameObject.SetActive(true);
			player4.PlayerNameTableText.gameObject.SetActive(true);
			player4.PlayerNameTableText.text = player4.Name;
		}
		if (players.Count == 2)
		{
			GreenTokens.RemoveRange(GreenTokens.Count-3  ,3);
			BlackTokens.RemoveRange(BlackTokens.Count - 3, 3);
			WhiteTokens.RemoveRange(WhiteTokens.Count - 3, 3);
			RedTokens.RemoveRange(RedTokens.Count - 3, 3);
			BlueTokens.RemoveRange(BlueTokens.Count - 3, 3);

			DrawNobleCards(2);
		}
		else if (players.Count == 3)
		{
			GreenTokens.RemoveRange(GreenTokens.Count - 2, 2);
			BlackTokens.RemoveRange(BlackTokens.Count - 2, 2);
			WhiteTokens.RemoveRange(WhiteTokens.Count - 2, 2);
			RedTokens.RemoveRange(RedTokens.Count - 2, 2);
			BlueTokens.RemoveRange(BlueTokens.Count - 2, 2);

			DrawNobleCards(3);
		}
        else
        {
            DrawNobleCards(4);
        }

    }

	public void DrawInitialCards()
	{
		// Draw 4 cards from deck 1
		for (int i = 0; i < 4; i++)
		{
			DrawCard(deck1, cardSlots[i], i);
            availableCardSlotsDeck1[i] = false;
        }

		// Draw 4 cards from deck 2
		for (int i = 4; i < 8; i++)
		{
			DrawCard(deck2, cardSlots[i], i);
            availableCardSlotsDeck2[i - 4] = false;
		}

		// Draw 4 cards from deck 3
		for (int i = 8; i < 12; i++)
		{
			DrawCard(deck3, cardSlots[i], i);
            availableCardSlotsDeck3[i - 8] = false;
		}
	}

    public void DrawNobleCards(int playerNumber)
    {
        if (playerNumber == 2)
        {
            for (int i = 0; i < 3; i++)
            {
				DrawCard(nobleDeck, nobleCardSlots[i], i);
            }
        }
        if (playerNumber == 3)
        {
            for (int i = 0; i < 4; i++)
            {
                DrawCard(nobleDeck, nobleCardSlots[i], i);
            }
        }
        if (playerNumber == 4)
        {
            for (int i = 0; i < 5; i++)
            {
                DrawCard(nobleDeck, nobleCardSlots[i], i);
            }
        }
	}

    private void PutTokensInPositions()
    {
		// Reset Offset before initial loading
		Offset = 0;
		foreach (Token t in GreenTokens)
        {
			t.gameObject.SetActive(true);
			Offset += (float)0.3;
			t.transform.position = greenTokenSlot.position + new Vector3(Offset, 0, 0);
		}

		Offset = 0;
        foreach (Token t in BlackTokens)
        {
			t.gameObject.SetActive(true);
			Offset += (float)0.3;
			t.transform.position = blackTokenSlot.position + new Vector3(Offset, 0, 0);
		}
		
		Offset = 0;
		foreach (Token t in BlueTokens)
        {
			t.gameObject.SetActive(true);
			Offset += (float)0.3;
			t.transform.position = blueTokenSlot.position + new Vector3(Offset, 0, 0);
		}
		
		Offset = 0;
		foreach (Token t in RedTokens)
        {
			t.gameObject.SetActive(true);
			Offset += (float)0.3;
			t.transform.position = redTokenSlot.position + new Vector3(Offset, 0, 0);
		}

		Offset = 0;
		foreach (Token t in WhiteTokens)
        {
			t.gameObject.SetActive(true);
			Offset += (float)0.3;
			t.transform.position = whiteTokenSlot.position + new Vector3(Offset, 0, 0);
		}

		Offset = 0;
		foreach (Token t in GoldTokens)
		{
			t.gameObject.SetActive(true);
			Offset += (float)0.3;
			t.transform.position = goldTokenSlot.position + new Vector3(Offset, 0, 0);
		}
	}

	public void DrawCard(List<Card> deck, Transform slot, int index)
    {
        // Draw a card from the deck
		var card = deck[0];
        card.gameObject.SetActive(true);
		card.transform.position = slot.position;
        card.Index = index;
        deck.RemoveAt(0);
	}

    public int FirstAvailableSlot(Colors.Color cardColor)
    {
		switch (cardColor)
		{
			case Colors.Color.Green:
				for (int i = 0; i < GetPlayer().GreenCardSlotsAvailable.Length; i++)
				{
					if (!GetPlayer().GreenCardSlotsAvailable[i])
						return i;
				}

				break;
			case Colors.Color.Black:
				for (int i = 0; i < GetPlayer().BlackCardSlotsAvailable.Length; i++)
				{
					if (!GetPlayer().BlackCardSlotsAvailable[i])
						return i;
				}

				break;
			case Colors.Color.Blue:
				for (int i = 0; i < GetPlayer().BlueCardSlotsAvailable.Length; i++)
				{
					if (!GetPlayer().BlueCardSlotsAvailable[i])
						return i;
				}

				break;
			case Colors.Color.Red:
				for (int i = 0; i < GetPlayer().RedCardSlotsAvailable.Length; i++)
				{
					if (!GetPlayer().RedCardSlotsAvailable[i])
						return i;
				}

				break;
			case Colors.Color.White:
				for (int i = 0; i < GetPlayer().WhiteCardSlotsAvailable.Length; i++)
				{
					if (!GetPlayer().WhiteCardSlotsAvailable[i])
						return i;
				}

				break;
			case Colors.Color.Noble:
				for(int i = 0; i < GetPlayer().NobleCardSlotsAvailable.Length; i++)
                {
					if (!GetPlayer().WhiteCardSlotsAvailable[i])
						return i;
                }

				break;
		}

		return -1;
	}

    public int FirstAvailableToken(Colors.Color tokenColor)
    {
        switch (tokenColor)
        {
			case Colors.Color.Green:
                for (int i = 0; i < GreenTokens.Count; i++)
                {
                    if (GreenTokens[i].Available)
                        return i;
                }

                break;
			case Colors.Color.Black:
                for (int i = 0; i < BlackTokens.Count; i++)
                {
                    if (BlackTokens[i].Available)
                        return i;
                }
				break;
			case Colors.Color.Blue:
                for (int i = 0; i < BlueTokens.Count; i++)
                {
                    if (BlueTokens[i].Available)
                        return i;
                }
				break;
			case Colors.Color.Gold:
                for (int i = 0; i < GoldTokens.Count; i++)
                {
                    if (GoldTokens[i].Available)
                        return i;
                }
				break;
			case Colors.Color.Red:
                for (int i = 0; i < RedTokens.Count; i++)
                {
                    if (RedTokens[i].Available)
                        return i;
                }
				break;
			case Colors.Color.White:
                for (int i = 0; i < WhiteTokens.Count; i++)
                {
                    if (WhiteTokens[i].Available)
                        return i;
                }
				break;
			default:
                return -1;
        }

        return -1;
    }

    public int FirstNotAvailableToken(Colors.Color tokenColor)
    {
        switch (tokenColor)
        {
            case Colors.Color.Green:
                for (int i = 0; i < GreenTokens.Count; i++)
                {
                    if (!GreenTokens[i].Available && GreenTokens[i].InPossession == GetPlayer())
                        return i;
                }

                break;
            case Colors.Color.Black:
                for (int i = 0; i < BlackTokens.Count; i++)
                {
					if (!BlackTokens[i].Available && BlackTokens[i].InPossession == GetPlayer())
						return i;
                }
                break;
            case Colors.Color.Blue:
                for (int i = 0; i < BlueTokens.Count; i++)
                {
					if (!BlueTokens[i].Available && BlueTokens[i].InPossession == GetPlayer())
						return i;
                }
                break;
            case Colors.Color.Gold:
                for (int i = 0; i < GoldTokens.Count; i++)
                {
					if (!GoldTokens[i].Available && GoldTokens[i].InPossession == GetPlayer())
						return i;
                }
                break;
            case Colors.Color.Red:
                for (int i = 0; i < RedTokens.Count; i++)
                {
					if (!RedTokens[i].Available && RedTokens[i].InPossession == GetPlayer())
						return i;
                }
                break;
            case Colors.Color.White:
                for (int i = 0; i < WhiteTokens.Count; i++)
                {
					if (!WhiteTokens[i].Available && WhiteTokens[i].InPossession == GetPlayer())
						return i;
                }
                break;
            default:
                return -1;
        }

        return -1;
    }

	public int AllAvailableTokens(List<Token> tokens)
	{
		int count = 0;
		Colors.Color tokenColor = tokens[0].Color;
		switch (tokenColor)
		{
			case Colors.Color.Green:
				for (int i = 0; i < GreenTokens.Count; i++)
				{
					if (GreenTokens[i].Available)
						count++;
				}

				break;
			case Colors.Color.Black:
				for (int i = 0; i < BlackTokens.Count; i++)
				{
					if (BlackTokens[i].Available)
						count++;
				}
				break;
			case Colors.Color.Blue:
				for (int i = 0; i < BlueTokens.Count; i++)
				{
					if (BlueTokens[i].Available)
						count++;
				}
				break;
			case Colors.Color.Gold:
				for (int i = 0; i < GoldTokens.Count; i++)
				{
					if (GoldTokens[i].Available)
						count++;
				}
				break;
			case Colors.Color.Red:
				for (int i = 0; i < RedTokens.Count; i++)
				{
					if (RedTokens[i].Available)
						count++;
				}
				break;
			case Colors.Color.White:
				for (int i = 0; i < WhiteTokens.Count; i++)
				{
					if (WhiteTokens[i].Available)
						count++;
				}
				break;
			default:
				return count;
		}

		return count;
	}

	public Player GetPlayer()
	{
		if (player1.IsTurn)
			return player1; 
		if (player2.IsTurn)
			return player2;
		if (player3.IsTurn)
			return player3;
		if (player4.IsTurn)
			return player4;
		return null;
	}
	
	public void NextPlayer(Player previousPlayer)
	{
		if (previousPlayer == player1)
		{
			previousPlayer.IsTurn = false;
			if (player2.gameObject.activeSelf)
			{
				if(player2.isPotentialWinner)
                {
					EndGame();
                }
				player2.IsTurn = true;
				return;
			}

			if (player3.gameObject.activeSelf)
			{
				if (player3.isPotentialWinner)
				{
					EndGame();
				}
				player3.IsTurn = true;
				return;
			}

			if (player4.gameObject.activeSelf)
			{
				if (player4.isPotentialWinner)
				{
					EndGame();
				}
				player4.IsTurn = true;
				return;				
			}
		}

		if (previousPlayer == player2)
		{
			previousPlayer.IsTurn = false;
			if (player3.gameObject.activeSelf)
			{
				if (player3.isPotentialWinner)
				{
					EndGame();
				}
				player3.IsTurn = true;
				return;
			}

			if (player4.gameObject.activeSelf)
			{
				if (player4.isPotentialWinner)
				{
					EndGame();
				}
				player4.IsTurn = true;
				return;
			}
			
			if (player1.gameObject.activeSelf)
			{
				if (player1.isPotentialWinner)
				{
					EndGame();
				}
				player1.IsTurn = true;
				return;
			}
		}

		if (previousPlayer == player3)
		{
			previousPlayer.IsTurn = false;
			if (player4.gameObject.activeSelf)
			{
				if (player4.isPotentialWinner)
				{
					EndGame();
				}
				player4.IsTurn = true;
				return;
			}
			
			if (player1.gameObject.activeSelf)
			{
				if (player1.isPotentialWinner)
				{
					EndGame();
				}
				player1.IsTurn = true;
				return;
			}

			if (player2.gameObject.activeSelf)
			{
				if (player2.isPotentialWinner)
				{
					EndGame();
				}
				player2.IsTurn = true;
				return;
			}
		}

		if (previousPlayer == player4)
		{
			if (player1.gameObject.activeSelf)
			{
				if (player1.isPotentialWinner)
				{
					EndGame();
				}
				player1.IsTurn = true;
				return;
			}

			if (player2.gameObject.activeSelf)
			{
				if (player2.isPotentialWinner)
				{
					EndGame();
				}
				player2.IsTurn = true;
				return;
			}

			if (player3.gameObject.activeSelf)
			{
				if (player3.isPotentialWinner)
				{
					EndGame();
				}
				player3.IsTurn = true;
				return;				
			}
		}
	}
}