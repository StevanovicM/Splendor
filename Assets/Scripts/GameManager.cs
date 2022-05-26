using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

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
#region DecksAndCards

	public List<Card> deck1 = new ();
	public List<Card> deck2 = new ();
	public List<Card> deck3 = new ();
	public List<Card> nobleDeck = new();

	private readonly Card blackCard1 = new ("Black", 0, 0, 1, 1, 1, 1);
	private readonly Card blackCard2 = new ("Black", 0, 0, 0, 1, 0, 2);
	private readonly Card blackCard3 = new ("Black", 0, 0, 2, 0, 0, 2);
	private readonly Card blackCard4 = new ("Black", 0, 1, 0, 3, 0, 1);
	private readonly Card blackCard5 = new ("Black", 0, 0, 0, 0, 0, 3);
	private readonly Card blackCard6 = new ("Black", 0, 0, 1, 1, 2, 1);
	private readonly Card blackCard7 = new ("Black", 0, 0, 2, 1, 2, 0);
	private readonly Card blackCard8 = new ("Black", 1, 0, 0, 0, 4, 0);
	private readonly Card blackCard9 = new ("Black", 1, 0, 3, 0, 2, 1);
	private readonly Card blackCard10 = new ("Black", 1, 2, 3, 0, 0, 3);
	private readonly Card blackCard11 = new ("Black", 2, 0, 0, 2, 1, 4);
	private readonly Card blackCard12 = new ("Black", 2, 0, 5, 0, 0, 0);
	private readonly Card blackCard13 = new ("Black", 2, 0, 0, 3, 0, 5);
	private readonly Card blackCard14 = new ("Black", 3, 6, 0, 0, 0, 0);
	private readonly Card blackCard15 = new ("Black", 3, 0, 3, 3, 3, 5);
	private readonly Card blackCard16 = new ("Black", 4, 0, 0, 7, 0, 0);
	private readonly Card blackCard17 = new ("Black", 4, 3, 0, 6, 0, 3);
	private readonly Card blackCard18 = new ("Black", 5, 3, 0, 7, 0, 0);

	private readonly Card blueCard1 = new ("Blue", 0, 2, 1, 0, 0, 0);
	private readonly Card blueCard2 = new ("Blue", 0, 1, 1, 2, 0, 1);
	private readonly Card blueCard3 = new ("Blue", 0, 1, 1, 1, 0, 1);
	private readonly Card blueCard4 = new ("Blue", 0, 0, 0, 1, 1, 3);
	private readonly Card blueCard5 = new ("Blue", 0, 3, 0, 0, 0, 0);
	private readonly Card blueCard6 = new ("Blue", 0, 0, 1, 2, 0, 2);
	private readonly Card blueCard7 = new ("Blue", 0, 2, 0, 0, 0, 2);
	private readonly Card blueCard8 = new ("Blue", 1, 0, 0, 4, 0, 0);
	private readonly Card blueCard9 = new ("Blue", 1, 0, 0, 3, 2, 1);
	private readonly Card blueCard10 = new ("Blue", 1, 3, 0, 0, 2, 3);
	private readonly Card blueCard11 = new ("Blue", 2, 0, 5, 0, 3, 4);
	private readonly Card blueCard12 = new ("Blue", 2, 0, 0, 0, 5, 0);
	private readonly Card blueCard13 = new ("Blue", 2, 4, 2, 1, 0, 5);
	private readonly Card blueCard14 = new ("Blue", 3, 0, 0, 0, 6, 0);
	private readonly Card blueCard15 = new ("Blue", 3, 5, 3, 3, 0, 5);
	private readonly Card blueCard16 = new ("Blue", 4, 0, 7, 0, 0, 0);
	private readonly Card blueCard17 = new ("Blue", 4, 3, 6, 0, 3, 3);
	private readonly Card blueCard18 = new ("Blue", 5, 0, 7, 0, 3, 0);

	private readonly Card greenCard1 = new ("Green", 0, 0, 2, 0, 1, 0);
	private readonly Card greenCard2 = new ("Green", 0, 0, 0, 2, 2, 0);
	private readonly Card greenCard3 = new ("Green", 0, 0, 1, 0, 3, 1);
	private readonly Card greenCard4 = new ("Green", 0, 1, 1, 1, 1, 0);
	private readonly Card greenCard5 = new ("Green", 0, 2, 1, 1, 1, 0);
	private readonly Card greenCard6 = new ("Green", 0, 2, 0, 2, 1, 0);
	private readonly Card greenCard7 = new ("Green", 0, 0, 0, 3, 0, 0);
	private readonly Card greenCard8 = new ("Green", 1, 4, 0, 0, 0, 0);
	private readonly Card greenCard9 = new ("Green", 1, 0, 3, 3, 0, 2);
	private readonly Card greenCard10 = new ("Green", 1, 2, 2, 0, 3, 0);
	private readonly Card greenCard11 = new ("Green", 2, 1, 4, 0, 2, 0);
	private readonly Card greenCard12 = new ("Green", 2, 0, 0, 0, 0, 5);
	private readonly Card greenCard13 = new ("Green", 2, 0, 0, 0, 5, 3);
	private readonly Card greenCard14 = new ("Green", 3, 0, 0, 0, 0, 6);
	private readonly Card greenCard15 = new ("Green", 3, 3, 5, 3, 3, 0);
	private readonly Card greenCard16 = new ("Green", 4, 0, 3, 0, 6, 3);
	private readonly Card greenCard17 = new ("Green", 4, 0, 0, 0, 7, 0);
	private readonly Card greenCard18 = new ("Green", 5, 0, 0, 0, 7, 3);

	private readonly Card redCard1 = new ("Red", 0, 0, 3, 0, 0, 0);
	private readonly Card redCard2 = new ("Red", 0, 3, 1, 1, 0, 0);
	private readonly Card redCard3 = new ("Red", 0, 0, 0, 0, 2, 1);
	private readonly Card redCard4 = new ("Red", 0, 2, 2, 0, 0, 1);
	private readonly Card redCard5 = new ("Red", 0, 1, 2, 0, 1, 1);
	private readonly Card redCard6 = new ("Red", 0, 1, 1, 0, 1, 1);
	private readonly Card redCard7 = new ("Red", 0, 0, 2, 2, 0, 0);
	private readonly Card redCard8 = new ("Red", 1, 0, 4, 0, 0, 0);
	private readonly Card redCard9 = new ("Red", 1, 3, 0, 2, 3, 0);
	private readonly Card redCard10 = new ("Red", 1, 3, 2, 2, 0, 0);
	private readonly Card redCard11 = new ("Red", 2, 0, 1, 0, 4, 2);
	private readonly Card redCard12 = new ("Red", 2, 5, 3, 0, 0, 0);
	private readonly Card redCard13 = new ("Red", 2, 5, 0, 0, 0, 0);
	private readonly Card redCard14 = new ("Red", 3, 0, 0, 6, 0, 0);
	private readonly Card redCard15 = new ("Red", 3, 3, 3, 0, 5, 3);
	private readonly Card redCard16 = new ("Red", 4, 0, 0, 0, 0, 7);
	private readonly Card redCard17 = new ("Red", 4, 0, 0, 3, 3, 6);
	private readonly Card redCard18 = new ("Red", 5, 0, 0, 3, 0, 7);

	private readonly Card whiteCard1 = new ("White", 0, 1, 0, 0, 2, 2);
	private readonly Card whiteCard2 = new ("White", 0, 1, 0, 2, 0, 0);
	private readonly Card whiteCard3 = new ("White", 0, 1, 0, 1, 1, 1);
	private readonly Card whiteCard4 = new ("White", 0, 0, 0, 0, 3, 0);
	private readonly Card whiteCard5 = new ("White", 0, 0, 0, 0, 2, 2);
	private readonly Card whiteCard6 = new ("White", 0, 1, 0, 1, 1, 2);
	private readonly Card whiteCard7 = new ("White", 0, 1, 3, 0, 1, 0);
	private readonly Card whiteCard8 = new ("White", 1, 0, 0, 0, 0, 4);
	private readonly Card whiteCard9 = new ("White", 1, 2, 0, 2, 0, 3);
	private readonly Card whiteCard10 = new ("White", 1, 0, 2, 3, 3, 0);
	private readonly Card whiteCard11 = new ("White", 2, 2, 0, 4, 0, 1);
	private readonly Card whiteCard12 = new ("White", 2, 0, 0, 5, 0, 0);
	private readonly Card whiteCard13 = new ("White", 2, 3, 0, 5, 0, 0);
	private readonly Card whiteCard14 = new ("White", 3, 0, 6, 0, 0, 0);
	private readonly Card whiteCard15 = new ("White", 3, 3, 0, 5, 3, 3);
	private readonly Card whiteCard16 = new ("White", 4, 7, 0, 0, 0, 0);
	private readonly Card whiteCard17 = new ("White", 4, 6, 3, 3, 0, 0);
	private readonly Card whiteCard18 = new ("White", 5, 7, 3, 0, 0, 0);

	private readonly NobleCard nobleCard1 = new(3, 0, 0, 4, 4, 0);
	private readonly NobleCard nobleCard2 = new(3, 3, 3, 3, 0, 0);
	private readonly NobleCard nobleCard3 = new(3, 0, 4, 0, 0, 4);
	private readonly NobleCard nobleCard4 = new(3, 4, 4, 0, 0, 0);
	private readonly NobleCard nobleCard5 = new(3, 0, 0, 0, 4, 4);
	private readonly NobleCard nobleCard6 = new(3, 0, 0, 3, 3, 3);
	private readonly NobleCard nobleCard7 = new(3, 0, 3, 0, 3, 3);
	private readonly NobleCard nobleCard8 = new(3, 4, 0, 4, 0, 0);
	private readonly NobleCard nobleCard9 = new(3, 3, 3, 0, 0, 3);
	private readonly NobleCard nobleCard10 = new(3, 3, 0, 3, 3, 0);

	#endregion

	public Transform[] cardSlots = new Transform[12];
	public Transform[] nobleCardSlots = new Transform[5];
	public bool[] availableCardSlots;
	#region Tokens
	public Token blackToken1 = new(1, "Black");
	public Token blackToken2 = new(1, "Black");
	public Token blackToken3 = new(1, "Black");
	public Token blackToken4 = new(1, "Black");
	public Token blackToken5 = new(1, "Black");
	public Token blackToken6 = new(1, "Black");
	public Token blackToken7 = new(1, "Black");

	public Token blueToken1 = new(1, "Blue");
	public Token blueToken2 = new(1, "Blue");
	public Token blueToken3 = new(1, "Blue");
	public Token blueToken4 = new(1, "Blue");
	public Token blueToken5 = new(1, "Blue");
	public Token blueToken6 = new(1, "Blue");
	public Token blueToken7 = new(1, "Blue");

	public Token greenToken1 = new(1, "Green");
	public Token greenToken2 = new(1, "Green");
	public Token greenToken3 = new(1, "Green");
	public Token greenToken4 = new(1, "Green");
	public Token greenToken5 = new(1, "Green");
	public Token greenToken6 = new(1, "Green");
	public Token greenToken7 = new(1, "Green");

	public Token redToken1 = new(1, "Red");
	public Token redToken2 = new(1, "Red");
	public Token redToken3 = new(1, "Red");
	public Token redToken4 = new(1, "Red");
	public Token redToken5 = new(1, "Red");
	public Token redToken6 = new(1, "Red");
	public Token redToken7 = new(1, "Red");

	public Token whiteToken1 = new(1, "Red");
	public Token whiteToken2 = new(1, "Red");
	public Token whiteToken3 = new(1, "Red");
	public Token whiteToken4 = new(1, "Red");
	public Token whiteToken5 = new(1, "Red");
	public Token whiteToken6 = new(1, "Red");
	public Token whiteToken7 = new(1, "Red");

	public Token goldToken1 = new(1, "Gold");
	public Token goldToken2 = new(1, "Gold");
	public Token goldToken3 = new(1, "Gold");
	public Token goldToken4 = new(1, "Gold");
	public Token goldToken5 = new(1, "Gold");

	public List<Token> blackTokens = new();
	public List<Token> blueTokens = new();
	public List<Token> greenTokens = new();
	public List<Token> redTokens = new();
	public List<Token> whiteTokens = new();
	public List<Token> goldTokens = new();
#endregion

	public Player player1;
	public Player player2;
	public Player player3;
	public Player player4;
	
	public List<Player> Players = new ();

	private void Start()
	{
#region Adding cards to the deck

		deck1.Add(blackCard1);
		deck1.Add(blackCard2);
		deck1.Add(blackCard3);
		deck1.Add(blackCard4);
		deck1.Add(blackCard5);
		deck1.Add(blackCard6);
		deck1.Add(blackCard7);
		deck1.Add(blackCard8);

		deck2.Add(blackCard9);
		deck2.Add(blackCard10);
		deck2.Add(blackCard11);
		deck2.Add(blackCard12);
		deck2.Add(blackCard13);
		deck2.Add(blackCard14);

		deck3.Add(blackCard15);
		deck3.Add(blackCard16);
		deck3.Add(blackCard17);
		deck3.Add(blackCard18);


		deck1.Add(blueCard1);
		deck1.Add(blueCard2);
		deck1.Add(blueCard3);
		deck1.Add(blueCard4);
		deck1.Add(blueCard5);
		deck1.Add(blueCard6);
		deck1.Add(blueCard7);
		deck1.Add(blueCard8);

		deck2.Add(blueCard9);
		deck2.Add(blueCard10);
		deck2.Add(blueCard11);
		deck2.Add(blueCard12);
		deck2.Add(blueCard13);
		deck2.Add(blueCard14);

		deck3.Add(blueCard15);
		deck3.Add(blueCard16);
		deck3.Add(blueCard17);
		deck3.Add(blueCard18);


		deck1.Add(greenCard1);
		deck1.Add(greenCard2);
		deck1.Add(greenCard3);
		deck1.Add(greenCard4);
		deck1.Add(greenCard5);
		deck1.Add(greenCard6);
		deck1.Add(greenCard7);
		deck1.Add(greenCard8);

		deck2.Add(greenCard9);
		deck2.Add(greenCard10);
		deck2.Add(greenCard11);
		deck2.Add(greenCard12);
		deck2.Add(greenCard13);
		deck2.Add(greenCard14);

		deck3.Add(greenCard15);
		deck3.Add(greenCard16);
		deck3.Add(greenCard17);
		deck3.Add(greenCard18);


		deck1.Add(redCard1);
		deck1.Add(redCard2);
		deck1.Add(redCard3);
		deck1.Add(redCard4);
		deck1.Add(redCard5);
		deck1.Add(redCard6);
		deck1.Add(redCard7);
		deck1.Add(redCard8);

		deck2.Add(redCard9);
		deck2.Add(redCard10);
		deck2.Add(redCard11);
		deck2.Add(redCard12);
		deck2.Add(redCard13);
		deck2.Add(redCard14);

		deck3.Add(redCard15);
		deck3.Add(redCard16);
		deck3.Add(redCard17);
		deck3.Add(redCard18);


		deck1.Add(whiteCard1);
		deck1.Add(whiteCard2);
		deck1.Add(whiteCard3);
		deck1.Add(whiteCard4);
		deck1.Add(whiteCard5);
		deck1.Add(whiteCard6);
		deck1.Add(whiteCard7);
		deck1.Add(whiteCard8);

		deck2.Add(whiteCard9);
		deck2.Add(whiteCard10);
		deck2.Add(whiteCard11);
		deck2.Add(whiteCard12);
		deck2.Add(whiteCard13);
		deck2.Add(whiteCard14);

		deck3.Add(whiteCard15);
		deck3.Add(whiteCard16);
		deck3.Add(whiteCard17);
		deck3.Add(whiteCard18);


		nobleDeck.Add(nobleCard1);
		nobleDeck.Add(nobleCard2);
		nobleDeck.Add(nobleCard3);
		nobleDeck.Add(nobleCard4);
		nobleDeck.Add(nobleCard5);
		nobleDeck.Add(nobleCard6);
		nobleDeck.Add(nobleCard7);
		nobleDeck.Add(nobleCard8);
		nobleDeck.Add(nobleCard9);
		nobleDeck.Add(nobleCard10);

		#endregion

		//Shuffle the decks
		deck1 = Shuffle(deck1);
		deck2 = Shuffle(deck2);
		deck3 = Shuffle(deck3);
		nobleDeck = Shuffle(nobleDeck);

		DrawInitialCards();
		PopulateTokenLists();
	}

	private void PopulateTokenLists()
	{
		switch (Players.Count)
		{
			#region Populating the token lists and drawing noble cards
			case 2:
				greenTokens.Add(greenToken1);
				greenTokens.Add(greenToken2);
				greenTokens.Add(greenToken3);
				greenTokens.Add(greenToken4);

				redTokens.Add(redToken1);
				redTokens.Add(redToken2);
				redTokens.Add(redToken3);
				redTokens.Add(redToken4);

				whiteTokens.Add(whiteToken1);
				whiteTokens.Add(whiteToken2);
				whiteTokens.Add(whiteToken3);
				whiteTokens.Add(whiteToken4);

				blueTokens.Add(blueToken1);
				blueTokens.Add(blueToken2);
				blueTokens.Add(blueToken3);
				blueTokens.Add(blueToken4);

				blackTokens.Add(blackToken1);
				blackTokens.Add(blackToken2);
				blackTokens.Add(blackToken3);
				blackTokens.Add(blackToken4);

				goldTokens.Add(goldToken1);
				goldTokens.Add(goldToken2);
				goldTokens.Add(goldToken3);
				goldTokens.Add(goldToken4);
				goldTokens.Add(goldToken5);

				DrawCard(nobleDeck, nobleCardSlots[0]);
				DrawCard(nobleDeck, nobleCardSlots[1]);
				DrawCard(nobleDeck, nobleCardSlots[2]);
				break;
			case 3:
				greenTokens.Add(greenToken1);
				greenTokens.Add(greenToken2);
				greenTokens.Add(greenToken3);
				greenTokens.Add(greenToken4);
				greenTokens.Add(greenToken5);

				redTokens.Add(redToken1);
				redTokens.Add(redToken2);
				redTokens.Add(redToken3);
				redTokens.Add(redToken4);
				redTokens.Add(redToken5);

				whiteTokens.Add(whiteToken1);
				whiteTokens.Add(whiteToken2);
				whiteTokens.Add(whiteToken3);
				whiteTokens.Add(whiteToken4);
				whiteTokens.Add(whiteToken5);

				blueTokens.Add(blueToken1);
				blueTokens.Add(blueToken2);
				blueTokens.Add(blueToken3);
				blueTokens.Add(blueToken4);
				blueTokens.Add(blueToken5);

				blackTokens.Add(blackToken1);
				blackTokens.Add(blackToken2);
				blackTokens.Add(blackToken3);
				blackTokens.Add(blackToken4);
				blackTokens.Add(blackToken5);

				goldTokens.Add(goldToken1);
				goldTokens.Add(goldToken2);
				goldTokens.Add(goldToken3);
				goldTokens.Add(goldToken4);
				goldTokens.Add(goldToken5);

				DrawCard(nobleDeck, nobleCardSlots[0]);
				DrawCard(nobleDeck, nobleCardSlots[1]);
				DrawCard(nobleDeck, nobleCardSlots[2]);
				DrawCard(nobleDeck, nobleCardSlots[3]);
				break;
			case 4:
				greenTokens.Add(greenToken1);
				greenTokens.Add(greenToken2);
				greenTokens.Add(greenToken3);
				greenTokens.Add(greenToken4);
				greenTokens.Add(greenToken5);
				greenTokens.Add(greenToken6);
				greenTokens.Add(greenToken7);

				redTokens.Add(redToken1);
				redTokens.Add(redToken2);
				redTokens.Add(redToken3);
				redTokens.Add(redToken4);
				redTokens.Add(redToken5);
				redTokens.Add(redToken6);
				redTokens.Add(redToken7);

				whiteTokens.Add(whiteToken1);
				whiteTokens.Add(whiteToken2);
				whiteTokens.Add(whiteToken3);
				whiteTokens.Add(whiteToken4);
				whiteTokens.Add(whiteToken5);
				whiteTokens.Add(whiteToken6);
				whiteTokens.Add(whiteToken7);

				blueTokens.Add(blueToken1);
				blueTokens.Add(blueToken2);
				blueTokens.Add(blueToken3);
				blueTokens.Add(blueToken4);
				blueTokens.Add(blueToken5);
				blueTokens.Add(blueToken6);
				blueTokens.Add(blueToken7);

				blackTokens.Add(blackToken1);
				blackTokens.Add(blackToken2);
				blackTokens.Add(blackToken3);
				blackTokens.Add(blackToken4);
				blackTokens.Add(blackToken5);
				blackTokens.Add(blackToken6);
				blackTokens.Add(blackToken7);

				goldTokens.Add(goldToken1);
				goldTokens.Add(goldToken2);
				goldTokens.Add(goldToken3);
				goldTokens.Add(goldToken4);
				goldTokens.Add(goldToken5);

				DrawCard(nobleDeck, nobleCardSlots[0]);
				DrawCard(nobleDeck, nobleCardSlots[1]);
				DrawCard(nobleDeck, nobleCardSlots[2]);
				DrawCard(nobleDeck, nobleCardSlots[3]);
				DrawCard(nobleDeck, nobleCardSlots[4]);
				break;
#endregion
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

	private void DrawInitialCards()
	{
		// Draw 4 cards from deck 1
		for (int i = 0; i < 4; i++)
		{
			DrawCard(deck1, cardSlots[i]);
		}

		// Draw 4 cards from deck 2
		for (int i = 4; i < 8; i++)
		{
			DrawCard(deck2, cardSlots[i]);
		}

		// Draw 4 cards from deck 3
		for (int i = 8; i < 12; i++)
		{
			DrawCard(deck3, cardSlots[i]);
		}
	}

	private void DrawCard(List<Card> deck, Transform slot)
	{
		// Draw a card from the deck
		var card = deck[0];
		card.gameObject.SetActive(true);
		card.transform.position = slot.position;
		deck.RemoveAt(0);
	}
}