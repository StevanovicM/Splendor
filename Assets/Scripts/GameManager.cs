using System.Collections.Generic;
using System.Linq;
using Assets.Scripts;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

//public List<Card> deck = new List<Card>();
//public List<Card> discardPile = new List<Card>();
//public Transform[] cardSlots;
//public bool[] availableCardSlots;

//public Text deckSizeText;
//public Text discardPileText;

//public void DrawCard()
//{
//    if (deck.Count < 1) return;
//    var randCard = deck[Random.Range(0, deck.Count)];

//    for (var i = 0; i < availableCardSlots.Length; i++)
//    {
//        if (availableCardSlots[i] != true) continue;
//        randCard.gameObject.SetActive(true);
//        randCard.handIndex = i;
//        randCard.transform.position = cardSlots[i].position;
//        randCard.hasBeenPlayed = false;
//        availableCardSlots[i] = false;
//        deck.Remove(randCard);
//        return;
//    }
//}

//public void Shuffle()
//{
//    if (discardPile.Count >= 1)
//    {
//        foreach (Card card in discardPile)
//        {
//            deck.Add(card);
//        }
//        discardPile.Clear();
//    }
//}

//private void Update()
//{
//    deckSizeText.text = deck.Count.ToString();
//    discardPileText.text = discardPile.Count.ToString();
//}


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
	public TMP_Text GoldCards;
	private Player PotentialWinner;


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
	//public Transform[] player1CardSlots = new Transform[12];
	public bool[] availableCardSlotsDeck1;
	public bool[] availableCardSlotsDeck2;
	public bool[] availableCardSlotsDeck3;
	//public bool[] availableCardSlotsPlayer1;


	public  Player player1;
	public  Player player2;
	public  Player player3;
	public  Player player4;

	public static List<Player> players = new();

	private void Start()
	{
		#region Adding cards to the deck

		//      Card blackCard1 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard2 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard3 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard4 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard5 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard6 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard7 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard8 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard9 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard10 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard11 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard12 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard13 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard14 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard15 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard16 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard17 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blackCard18 = gameObject.AddComponent(typeof(Card)) as Card;

		//deck1.Add(blackCard1);
		//deck1.Add(blackCard2);
		//deck1.Add(blackCard3);
		//deck1.Add(blackCard4);
		//deck1.Add(blackCard5);
		//deck1.Add(blackCard6);
		//deck1.Add(blackCard7);
		//deck1.Add(blackCard8);

		//deck2.Add(blackCard9);
		//deck2.Add(blackCard10);
		//deck2.Add(blackCard11);
		//deck2.Add(blackCard12);
		//deck2.Add(blackCard13);
		//deck2.Add(blackCard14);

		//deck3.Add(blackCard15);
		//deck3.Add(blackCard16);
		//deck3.Add(blackCard17);
		//deck3.Add(blackCard18);

		//Card blueCard1 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard2 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard3 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard4 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard5 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard6 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard7 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard8 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard9 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard10 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard11 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard12 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard13 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard14 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard15 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard16 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard17 = gameObject.AddComponent(typeof(Card)) as Card;
		//Card blueCard18 = gameObject.AddComponent(typeof(Card)) as Card;


		//deck1.Add(blueCard1);
		//deck1.Add(blueCard2);
		//deck1.Add(blueCard3);
		//deck1.Add(blueCard4);
		//deck1.Add(blueCard5);
		//deck1.Add(blueCard6);
		//deck1.Add(blueCard7);
		//deck1.Add(blueCard8);

		//deck2.Add(blueCard9);
		//deck2.Add(blueCard10);
		//deck2.Add(blueCard11);
		//deck2.Add(blueCard12);
		//deck2.Add(blueCard13);
		//deck2.Add(blueCard14);

		//deck3.Add(blueCard15);
		//deck3.Add(blueCard16);
		//deck3.Add(blueCard17);
		//deck3.Add(blueCard18);

		//      Card greenCard1 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard2 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard3 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard4 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard5 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard6 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard7 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard8 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard9 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard10 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard11 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard12 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard13 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard14 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard15 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard16 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard17 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card greenCard18 = gameObject.AddComponent(typeof(Card)) as Card;

		//deck1.Add(greenCard1);
		//deck1.Add(greenCard2);
		//deck1.Add(greenCard3);
		//deck1.Add(greenCard4);
		//deck1.Add(greenCard5);
		//deck1.Add(greenCard6);
		//deck1.Add(greenCard7);
		//deck1.Add(greenCard8);

		//deck2.Add(greenCard9);
		//deck2.Add(greenCard10);
		//deck2.Add(greenCard11);
		//deck2.Add(greenCard12);
		//deck2.Add(greenCard13);
		//deck2.Add(greenCard14);

		//deck3.Add(greenCard15);
		//deck3.Add(greenCard16);
		//deck3.Add(greenCard17);
		//deck3.Add(greenCard18);


		//      Card redCard1 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard2 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard3 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard4 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard5 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard6 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard7 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard8 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard9 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard10 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard11 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard12 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard13 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard14 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard15 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard16 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard17 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card redCard18 = gameObject.AddComponent(typeof(Card)) as Card;


		//deck1.Add(redCard1);
		//deck1.Add(redCard2);
		//deck1.Add(redCard3);
		//deck1.Add(redCard4);
		//deck1.Add(redCard5);
		//deck1.Add(redCard6);
		//deck1.Add(redCard7);
		//deck1.Add(redCard8);

		//deck2.Add(redCard9);
		//deck2.Add(redCard10);
		//deck2.Add(redCard11);
		//deck2.Add(redCard12);
		//deck2.Add(redCard13);
		//deck2.Add(redCard14);

		//deck3.Add(redCard15);
		//deck3.Add(redCard16);
		//deck3.Add(redCard17);
		//deck3.Add(redCard18);

		//      Card whiteCard1 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard2 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard3 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard4 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard5 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard6 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard7 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard8 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard9 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard10 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard11 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard12 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard13 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard14 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard15 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard16 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard17 = gameObject.AddComponent(typeof(Card)) as Card;
		//      Card whiteCard18 = gameObject.AddComponent(typeof(Card)) as Card;


		//deck1.Add(whiteCard1);
		//deck1.Add(whiteCard2);
		//deck1.Add(whiteCard3);
		//deck1.Add(whiteCard4);
		//deck1.Add(whiteCard5);
		//deck1.Add(whiteCard6);
		//deck1.Add(whiteCard7);
		//deck1.Add(whiteCard8);

		//deck2.Add(whiteCard9);
		//deck2.Add(whiteCard10);
		//deck2.Add(whiteCard11);
		//deck2.Add(whiteCard12);
		//deck2.Add(whiteCard13);
		//deck2.Add(whiteCard14);

		//deck3.Add(whiteCard15);
		//deck3.Add(whiteCard16);
		//deck3.Add(whiteCard17);
		//deck3.Add(whiteCard18);

		//      NobleCard nobleCard1 = gameObject.AddComponent(typeof(NobleCard)) as NobleCard;
		//      NobleCard nobleCard2 = gameObject.AddComponent(typeof(NobleCard)) as NobleCard;
		//      NobleCard nobleCard3 = gameObject.AddComponent(typeof(NobleCard)) as NobleCard;
		//      NobleCard nobleCard4 = gameObject.AddComponent(typeof(NobleCard)) as NobleCard;
		//      NobleCard nobleCard5 = gameObject.AddComponent(typeof(NobleCard)) as NobleCard;
		//      NobleCard nobleCard6 = gameObject.AddComponent(typeof(NobleCard)) as NobleCard;
		//      NobleCard nobleCard7 = gameObject.AddComponent(typeof(NobleCard)) as NobleCard;
		//      NobleCard nobleCard8 = gameObject.AddComponent(typeof(NobleCard)) as NobleCard;
		//      NobleCard nobleCard9 = gameObject.AddComponent(typeof(NobleCard)) as NobleCard;
		//      NobleCard nobleCard10 = gameObject.AddComponent(typeof(NobleCard)) as NobleCard;


		//nobleDeck.Add(nobleCard1);
		//nobleDeck.Add(nobleCard2);
		//nobleDeck.Add(nobleCard3);
		//nobleDeck.Add(nobleCard4);
		//nobleDeck.Add(nobleCard5);
		//nobleDeck.Add(nobleCard6);
		//nobleDeck.Add(nobleCard7);
		//nobleDeck.Add(nobleCard8);
		//nobleDeck.Add(nobleCard9);
		//nobleDeck.Add(nobleCard10);

		#endregion

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
		PotentialWinner = GetPlayer();
		PlayerTurn.text = "Winner: " + PotentialWinner.name + "!! " + PotentialWinner.Points + " points";
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
			Application.Quit();
		}
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
		}

		if (OptionsMenu.Player2Active)
		{
			player2.gameObject.SetActive(true);
			player2.Name = OptionsMenu.Player2Name;
			players.Add(player2);
		}

		if (OptionsMenu.Player3Active)
		{
			player3.gameObject.SetActive(true);
			player3.Name = OptionsMenu.Player3Name;
			players.Add(player3);
		}
		if (OptionsMenu.Player4Active)
		{
			player4.gameObject.SetActive(true);
			player4.Name = OptionsMenu.Player4Name;
			players.Add(player4);
		}
		if (players.Count == 2)
		{
			GreenTokens.RemoveRange(GreenTokens.Count-3  ,3);
			BlackTokens.RemoveRange(BlackTokens.Count - 3, 3);
			WhiteTokens.RemoveRange(WhiteTokens.Count - 3, 3);
			RedTokens.RemoveRange(RedTokens.Count - 3, 3);
			BlueTokens.RemoveRange(BlueTokens.Count - 3, 3);

			// Reveal 3 noble cards
		}
		else if (players.Count == 3)
		{
			GreenTokens.RemoveRange(GreenTokens.Count - 2, 2);
			BlackTokens.RemoveRange(BlackTokens.Count - 2, 2);
			WhiteTokens.RemoveRange(WhiteTokens.Count - 2, 2);
			RedTokens.RemoveRange(RedTokens.Count - 2, 2);
			BlueTokens.RemoveRange(BlueTokens.Count - 2, 2);

			// Reveal 4 noble cards
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
				player2.IsTurn = true;
				return;
			}

			if (player3.gameObject.activeSelf)
			{
				player3.IsTurn = true;
				return;
			}

			if (player4.gameObject.activeSelf)
			{
				player4.IsTurn = true;
				return;				
			}
		}

		if (previousPlayer == player2)
		{
			previousPlayer.IsTurn = false;
			if (player3.gameObject.activeSelf)
			{
				player3.IsTurn = true;
				return;
			}

			if (player4.gameObject.activeSelf)
			{
				player4.IsTurn = true;
				return;
			}
			
			if (player1.gameObject.activeSelf)
			{
				player1.IsTurn = true;
				return;
			}
		}

		if (previousPlayer == player3)
		{
			previousPlayer.IsTurn = false;
			if (player4.gameObject.activeSelf)
			{
				player4.IsTurn = true;
				return;
			}
			
			if (player1.gameObject.activeSelf)
			{
				player1.IsTurn = true;
				return;
			}

			if (player2.gameObject.activeSelf)
			{
				player2.IsTurn = true;
				return;
			}
		}

		if (previousPlayer == player4)
		{
			if (player1.gameObject.activeSelf)
			{
				player1.IsTurn = true;
				return;
			}

			if (player2.gameObject.activeSelf)
			{
				player2.IsTurn = true;
				return;
			}

			if (player3.gameObject.activeSelf)
			{
				player3.IsTurn = true;
				return;				
			}
		}
	}
}