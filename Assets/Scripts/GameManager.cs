using System.Collections.Generic;
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
    public List<Card> deck1 = new List<Card>();
    public List<Card> deck2 = new List<Card>();
    public List<Card> deck3 = new List<Card>();

    private readonly Card blackCard1 = new Card("Black", 0, 0, 1, 1, 1, 1);
    private readonly Card blackCard2 = new Card("Black", 0, 0, 0, 1, 0, 2);
    private readonly Card blackCard3 = new Card("Black", 0, 0, 2, 0, 0, 2);
    private readonly Card blackCard4 = new Card("Black", 0, 1, 0, 3, 0, 1);
    private readonly Card blackCard5 = new Card("Black", 0, 0, 0, 0, 0, 3);
    private readonly Card blackCard6 = new Card("Black", 0, 0, 1, 1, 2, 1);
    private readonly Card blackCard7 = new Card("Black", 0, 0, 2, 1, 2, 0);
    private readonly Card blackCard8 = new Card("Black", 1, 0, 0, 0, 4, 0);
    private readonly Card blackCard9 = new Card("Black", 1, 0, 3, 0, 2, 1);
    private readonly Card blackCard10 = new Card("Black", 1, 2, 3, 0, 0, 3);
    private readonly Card blackCard11 = new Card("Black", 2, 0, 0, 2, 1, 4);
    private readonly Card blackCard12 = new Card("Black", 2, 0, 5, 0, 0, 0);
    private readonly Card blackCard13 = new Card("Black", 2, 0, 0, 3, 0, 5);
    private readonly Card blackCard14 = new Card("Black", 3, 6, 0, 0, 0, 0);
    private readonly Card blackCard15 = new Card("Black", 3, 0, 3, 3, 3, 5);
    private readonly Card blackCard16 = new Card("Black", 4, 0, 0, 7, 0, 0);
    private readonly Card blackCard17 = new Card("Black", 4, 3, 0, 6, 0, 3);
    private readonly Card blackCard18 = new Card("Black", 5, 3, 0, 7, 0, 0);

    private readonly Card blueCard1 = new Card("Blue", 0, 2, 1, 0, 0, 0);
    private readonly Card blueCard2 = new Card("Blue", 0, 1, 1, 2, 0, 1);
    private readonly Card blueCard3 = new Card("Blue", 0, 1, 1, 1, 0, 1);
    private readonly Card blueCard4 = new Card("Blue", 0, 0, 0, 1, 1, 3);
    private readonly Card blueCard5 = new Card("Blue", 0, 3, 0, 0, 0, 0);
    private readonly Card blueCard6 = new Card("Blue", 0, 0, 1, 2, 0, 2);
    private readonly Card blueCard7 = new Card("Blue", 0, 2, 0, 0, 0, 2);
    private readonly Card blueCard8 = new Card("Blue", 1, 0, 0, 4, 0, 0);
    private readonly Card blueCard9 = new Card("Blue", 1, 0, 0, 3, 2, 1);
    private readonly Card blueCard10 = new Card("Blue", 1, 3, 0, 0, 2, 3);
    private readonly Card blueCard11 = new Card("Blue", 2, 0, 5, 0, 3, 4);
    private readonly Card blueCard12 = new Card("Blue", 2, 0, 0, 0, 5, 0);
    private readonly Card blueCard13 = new Card("Blue", 2, 4, 2, 1, 0, 5);
    private readonly Card blueCard14 = new Card("Blue", 3, 0, 0, 0, 6, 0);
    private readonly Card blueCard15 = new Card("Blue", 3, 5, 3, 3, 0, 5);
    private readonly Card blueCard16 = new Card("Blue", 4, 0, 7, 0, 0, 0);
    private readonly Card blueCard17 = new Card("Blue", 4, 3, 6, 0, 3, 3);
    private readonly Card blueCard18 = new Card("Blue", 5, 0, 7, 0, 3, 0);

    private readonly Card greenCard1 = new Card("Green", 0, 0, 2, 0, 1, 0);
    private readonly Card greenCard2 = new Card("Green", 0, 0, 0, 2, 2, 0);
    private readonly Card greenCard3 = new Card("Green", 0, 0, 1, 0, 3, 1);
    private readonly Card greenCard4 = new Card("Green", 0, 1, 1, 1, 1, 0);
    private readonly Card greenCard5 = new Card("Green", 0, 2, 1, 1, 1, 0);
    private readonly Card greenCard6 = new Card("Green", 0, 2, 0, 2, 1, 0);
    private readonly Card greenCard7 = new Card("Green", 0, 0, 0, 3, 0, 0);
    private readonly Card greenCard8 = new Card("Green", 1, 4, 0, 0, 0, 0);
    private readonly Card greenCard9 = new Card("Green", 1, 0, 3, 3, 0, 2);
    private readonly Card greenCard10 = new Card("Green", 1, 2, 2, 0, 3, 0);
    private readonly Card greenCard11 = new Card("Green", 2, 1, 4, 0, 2, 0);
    private readonly Card greenCard12 = new Card("Green", 2, 0, 0, 0, 0, 5);
    private readonly Card greenCard13 = new Card("Green", 2, 0, 0, 0, 5, 3);
    private readonly Card greenCard14 = new Card("Green", 3, 0, 0, 0, 0, 6);
    private readonly Card greenCard15 = new Card("Green", 3, 3, 5, 3, 3, 0);
    private readonly Card greenCard16 = new Card("Green", 4, 0, 3, 0, 6, 3);
    private readonly Card greenCard17 = new Card("Green", 4, 0, 0, 0, 7, 0);
    private readonly Card greenCard18 = new Card("Green", 5, 0, 0, 0, 7, 3);

    private readonly Card redCard1 = new Card("Red", 0, 0, 3, 0, 0, 0);
    private readonly Card redCard2 = new Card("Red", 0, 3, 1, 1, 0, 0);
    private readonly Card redCard3 = new Card("Red", 0, 0, 0, 0, 2, 1);
    private readonly Card redCard4 = new Card("Red", 0, 2, 2, 0, 0, 1);
    private readonly Card redCard5 = new Card("Red", 0, 1, 2, 0, 1, 1);
    private readonly Card redCard6 = new Card("Red", 0, 1, 1, 0, 1, 1);
    private readonly Card redCard7 = new Card("Red", 0, 0, 2, 2, 0, 0);
    private readonly Card redCard8 = new Card("Red", 1, 0, 4, 0, 0, 0);
    private readonly Card redCard9 = new Card("Red", 1, 3, 0, 2, 3, 0);
    private readonly Card redCard10 = new Card("Red", 1, 3, 2, 2, 0, 0);
    private readonly Card redCard11 = new Card("Red", 2, 0, 1, 0, 4, 2);
    private readonly Card redCard12 = new Card("Red", 2, 5, 3, 0, 0, 0);
    private readonly Card redCard13 = new Card("Red", 2, 5, 0, 0, 0, 0);
    private readonly Card redCard14 = new Card("Red", 3, 0, 0, 6, 0, 0);
    private readonly Card redCard15 = new Card("Red", 3, 3, 3, 0, 5, 3);
    private readonly Card redCard16 = new Card("Red", 4, 0, 0, 0, 0, 7);
    private readonly Card redCard17 = new Card("Red", 4, 0, 0, 3, 3, 6);
    private readonly Card redCard18 = new Card("Red", 5, 0, 0, 3, 0, 7);

    private readonly Card whiteCard1 = new Card("White", 0, 1, 0, 0, 2, 2);
    private readonly Card whiteCard2 = new Card("White", 0, 1, 0, 2, 0, 0);
    private readonly Card whiteCard3 = new Card("White", 0, 1, 0, 1, 1, 1);
    private readonly Card whiteCard4 = new Card("White", 0, 0, 0, 0, 3, 0);
    private readonly Card whiteCard5 = new Card("White", 0, 0, 0, 0, 2, 2);
    private readonly Card whiteCard6 = new Card("White", 0, 1, 0, 1, 1, 2);
    private readonly Card whiteCard7 = new Card("White", 0, 1, 3, 0, 1, 0);
    private readonly Card whiteCard8 = new Card("White", 1, 0, 0, 0, 0, 4);
    private readonly Card whiteCard9 = new Card("White", 1, 2, 0, 2, 0, 3);
    private readonly Card whiteCard10 = new Card("White", 1, 0, 2, 3, 3, 0);
    private readonly Card whiteCard11 = new Card("White", 2, 2, 0, 4, 0, 1);
    private readonly Card whiteCard12 = new Card("White", 2, 0, 0, 5, 0, 0);
    private readonly Card whiteCard13 = new Card("White", 2, 3, 0, 5, 0, 0);
    private readonly Card whiteCard14 = new Card("White", 3, 0, 6, 0, 0, 0);
    private readonly Card whiteCard15 = new Card("White", 3, 3, 0, 5, 3, 3);
    private readonly Card whiteCard16 = new Card("White", 4, 7, 0, 0, 0, 0);
    private readonly Card whiteCard17 = new Card("White", 4, 6, 3, 3, 0, 0);
    private readonly Card whiteCard18 = new Card("White", 5, 7, 3, 0, 0, 0);

    private void Start()
    {
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
    }
}