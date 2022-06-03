using System.Collections.Generic;
using Assets.Scripts;
using TMPro;
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
#region DecksAndCards

    public GameObject BlueTokenCounter;
	public List<Card> deck1 = new ();
	public List<Card> deck2 = new ();
	public List<Card> deck3 = new ();
	public List<Card> nobleDeck = new();

    public Token GreenToken;
    public Token BlackToken;
    public Token BlueToken;
    public Token RedToken;
    public Token WhiteToken;
    public Token GoldToken;
    

	#endregion

	public Transform[] cardSlots = new Transform[12];
	public Transform[] nobleCardSlots = new Transform[5];
    public bool[] availableCardSlotsDeck1;
	public bool[] availableCardSlotsDeck2;
	public bool[] availableCardSlotsDeck3;
	public bool[] availableCardSlotsPlayer1;

    public Player player1;
	public Player player2;
	public Player player3;
	public Player player4;
	
	public List<Player> Players = new ();

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



        DrawInitialCards();
        //PopulateTokenLists();
		player1.gameObject.SetActive(true);
        player1.GreenTokens++;
    }


//	private void PopulateTokenLists()
//    {
//		Token greenToken1 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token greenToken2 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token greenToken3 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token greenToken4 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token greenToken5 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token greenToken6 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token greenToken7 = gameObject.AddComponent(typeof(Token)) as Token;

//		Token redToken1 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token redToken2 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token redToken3 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token redToken4 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token redToken5 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token redToken6 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token redToken7 = gameObject.AddComponent(typeof(Token)) as Token;

//		Token whiteToken1 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token whiteToken2 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token whiteToken3 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token whiteToken4 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token whiteToken5 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token whiteToken6 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token whiteToken7 = gameObject.AddComponent(typeof(Token)) as Token;

//		Token blueToken1 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blueToken2 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blueToken3 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blueToken4 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blueToken5 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blueToken6 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blueToken7 = gameObject.AddComponent(typeof(Token)) as Token;

//		Token blackToken1 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blackToken2 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blackToken3 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blackToken4 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blackToken5 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blackToken6 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token blackToken7 = gameObject.AddComponent(typeof(Token)) as Token;

//		Token goldToken1 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token goldToken2 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token goldToken3 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token goldToken4 = gameObject.AddComponent(typeof(Token)) as Token;
//        Token goldToken5 = gameObject.AddComponent(typeof(Token)) as Token;
//		switch (Players.Count)
//		{
//			#region Populating the token lists and drawing noble cards
//			case 2:
//				greenTokens.Add(greenToken1);
//				greenTokens.Add(greenToken2);
//				greenTokens.Add(greenToken3);
//				greenTokens.Add(greenToken4);

//				redTokens.Add(redToken1);
//				redTokens.Add(redToken2);
//				redTokens.Add(redToken3);
//				redTokens.Add(redToken4);

//				whiteTokens.Add(whiteToken1);
//				whiteTokens.Add(whiteToken2);
//				whiteTokens.Add(whiteToken3);
//				whiteTokens.Add(whiteToken4);

//				blueTokens.Add(blueToken1);
//				blueTokens.Add(blueToken2);
//				blueTokens.Add(blueToken3);
//				blueTokens.Add(blueToken4);

//				blackTokens.Add(blackToken1);
//				blackTokens.Add(blackToken2);
//				blackTokens.Add(blackToken3);
//				blackTokens.Add(blackToken4);

//				goldTokens.Add(goldToken1);
//				goldTokens.Add(goldToken2);
//				goldTokens.Add(goldToken3);
//				goldTokens.Add(goldToken4);
//				goldTokens.Add(goldToken5);

//				DrawCard(nobleDeck, nobleCardSlots[0]);
//				DrawCard(nobleDeck, nobleCardSlots[1]);
//				DrawCard(nobleDeck, nobleCardSlots[2]);
//				break;
//			case 3:
//				greenTokens.Add(greenToken1);
//				greenTokens.Add(greenToken2);
//				greenTokens.Add(greenToken3);
//				greenTokens.Add(greenToken4);
//				greenTokens.Add(greenToken5);

//				redTokens.Add(redToken1);
//				redTokens.Add(redToken2);
//				redTokens.Add(redToken3);
//				redTokens.Add(redToken4);
//				redTokens.Add(redToken5);

//				whiteTokens.Add(whiteToken1);
//				whiteTokens.Add(whiteToken2);
//				whiteTokens.Add(whiteToken3);
//				whiteTokens.Add(whiteToken4);
//				whiteTokens.Add(whiteToken5);

//				blueTokens.Add(blueToken1);
//				blueTokens.Add(blueToken2);
//				blueTokens.Add(blueToken3);
//				blueTokens.Add(blueToken4);
//				blueTokens.Add(blueToken5);

//				blackTokens.Add(blackToken1);
//				blackTokens.Add(blackToken2);
//				blackTokens.Add(blackToken3);
//				blackTokens.Add(blackToken4);
//				blackTokens.Add(blackToken5);

//				goldTokens.Add(goldToken1);
//				goldTokens.Add(goldToken2);
//				goldTokens.Add(goldToken3);
//				goldTokens.Add(goldToken4);
//				goldTokens.Add(goldToken5);

//				DrawCard(nobleDeck, nobleCardSlots[0]);
//				DrawCard(nobleDeck, nobleCardSlots[1]);
//				DrawCard(nobleDeck, nobleCardSlots[2]);
//				DrawCard(nobleDeck, nobleCardSlots[3]);
//				break;
//			case 4:
//				greenTokens.Add(greenToken1);
//				greenTokens.Add(greenToken2);
//				greenTokens.Add(greenToken3);
//				greenTokens.Add(greenToken4);
//				greenTokens.Add(greenToken5);
//				greenTokens.Add(greenToken6);
//				greenTokens.Add(greenToken7);

//				redTokens.Add(redToken1);
//				redTokens.Add(redToken2);
//				redTokens.Add(redToken3);
//				redTokens.Add(redToken4);
//				redTokens.Add(redToken5);
//				redTokens.Add(redToken6);
//				redTokens.Add(redToken7);

//				whiteTokens.Add(whiteToken1);
//				whiteTokens.Add(whiteToken2);
//				whiteTokens.Add(whiteToken3);
//				whiteTokens.Add(whiteToken4);
//				whiteTokens.Add(whiteToken5);
//				whiteTokens.Add(whiteToken6);
//				whiteTokens.Add(whiteToken7);

//				blueTokens.Add(blueToken1);
//				blueTokens.Add(blueToken2);
//				blueTokens.Add(blueToken3);
//				blueTokens.Add(blueToken4);
//				blueTokens.Add(blueToken5);
//				blueTokens.Add(blueToken6);
//				blueTokens.Add(blueToken7);

//				blackTokens.Add(blackToken1);
//				blackTokens.Add(blackToken2);
//				blackTokens.Add(blackToken3);
//				blackTokens.Add(blackToken4);
//				blackTokens.Add(blackToken5);
//				blackTokens.Add(blackToken6);
//				blackTokens.Add(blackToken7);

//				goldTokens.Add(goldToken1);
//				goldTokens.Add(goldToken2);
//				goldTokens.Add(goldToken3);
//				goldTokens.Add(goldToken4);
//				goldTokens.Add(goldToken5);

//				DrawCard(nobleDeck, nobleCardSlots[0]);
//				DrawCard(nobleDeck, nobleCardSlots[1]);
//				DrawCard(nobleDeck, nobleCardSlots[2]);
//				DrawCard(nobleDeck, nobleCardSlots[3]);
//				DrawCard(nobleDeck, nobleCardSlots[4]);
//				break;
//#endregion
//		}
//    }

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

	public void DrawCard(List<Card> deck, Transform slot, int index)
    {
        // Draw a card from the deck
		var card = deck[0];
        card.gameObject.SetActive(true);
		card.transform.position = slot.position;
        card.Index = index;
        deck.RemoveAt(0);
	}
}