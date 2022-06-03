using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public bool hasBeenPlayed;

//public int handIndex;

//private GameManager gm;

//private void Start()
//{
//    gm = FindObjectOfType<GameManager>();
//}

//private void OnMouseDown()
//{
//    if (hasBeenPlayed == false)
//    {
//        transform.position += Vector3.up * 5;
//        hasBeenPlayed = true;
//        gm.availableCardSlots[handIndex] = true;
//        Invoke("MoveToDiscardPile", 2f);
//    }
//}

//private void MoveToDiscardPile()
//{
//    gm.discardPile.Add(this);
//    gameObject.SetActive(false);
//}

public class Card : MonoBehaviour
{
	public GameManager gm;
    public Colors.Color CardColor;
    public int CardPoints;
    public int CardCostBlack;
    public int CardCostWhite;
    public int CardCostRed;
    public int CardCostBlue;
    public int CardCostGreen;
    public int Index;

    public Card()
	{

	}

    public Card(Colors.Color color, int cardPoints, int cardCostBlack, int cardCostWhite, int cardCostRed,
        int cardCostBlue, int cardCostGreen, int index)
    {
        CardColor = color;
        CardPoints = cardPoints;
        CardCostBlack = cardCostBlack;
        CardCostWhite = cardCostWhite;
        CardCostRed = cardCostRed;
        CardCostBlue = cardCostBlue;
        CardCostGreen = cardCostGreen;
        Index = index;
    }
    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (CardCostBlack <= gm.player1.BlackTokens + gm.player1.BlackCards && CardCostWhite <= gm.player1.WhiteTokens + gm.player1.WhiteCards &&
                CardCostRed <= gm.player1.RedTokens + gm.player1.RedCards && CardCostBlue <= gm.player1.BlueTokens + gm.player1.BlueCards &&
                CardCostGreen <= gm.player1.GreenTokens + gm.player1.GreenCards)
            {
                this.gameObject.SetActive(false);
                if (Index is >= 0 and < 4)
                    gm.availableCardSlotsDeck1[Index] = true;
                if (Index is >= 4 and < 8)
                    gm.availableCardSlotsDeck2[Index - 4] = true;
                if (Index is >= 8 and < 12)
                    gm.availableCardSlotsDeck3[Index - 8] = true;

                for (int i = 0; i < 4; i++)
                {
                    if (gm.availableCardSlotsDeck1[i])
                    {
                        gm.DrawCard(gm.deck1, gm.cardSlots[i], i);
                        gm.availableCardSlotsDeck1[i] = false;
                    }

                    if (gm.availableCardSlotsDeck2[i])
                    {
                        gm.DrawCard(gm.deck2, gm.cardSlots[i + 4], i + 4);
                        gm.availableCardSlotsDeck2[i] = false;
                    }

                    if (gm.availableCardSlotsDeck3[i])
                    {
                        gm.DrawCard(gm.deck3, gm.cardSlots[i + 8], i + 8);
                        gm.availableCardSlotsDeck3[i] = false;
                    }
                }

                // If the player has enough cards there is no need to pay the tokens
                int tmpCardCostBlack = CardCostBlack - gm.player1.BlackCards;
                int tmpCardCostWhite = CardCostWhite - gm.player1.WhiteCards;
                int tmpCardCostRed   = CardCostRed - gm.player1.RedCards;
                int tmpCardCostBlue  = CardCostBlue - gm.player1.BlueCards;
                int tmpCardCostGreen = CardCostGreen - gm.player1.GreenCards;

                if (tmpCardCostBlack < 0)
                    tmpCardCostBlack = 0;
                if (tmpCardCostWhite < 0)
                    tmpCardCostWhite = 0;
                if (tmpCardCostRed < 0)
                    tmpCardCostRed = 0;
                if (tmpCardCostBlue < 0)
                    tmpCardCostBlue = 0;
                if (tmpCardCostGreen < 0)
                    tmpCardCostGreen = 0;


                gm.player1.BlackTokens -= tmpCardCostBlack;
                gm.BlackToken.NumberLeft += tmpCardCostBlack;
                gm.player1.WhiteTokens -= tmpCardCostWhite;
                gm.WhiteToken.NumberLeft += tmpCardCostWhite;
                gm.player1.RedTokens -= tmpCardCostRed;
                gm.RedToken.NumberLeft += tmpCardCostRed;
                gm.player1.BlueTokens -= tmpCardCostBlue;
                gm.BlueToken.NumberLeft += tmpCardCostBlue;
                gm.player1.GreenTokens -= tmpCardCostGreen;
                gm.GreenToken.NumberLeft += tmpCardCostGreen;

                if(gm.BlackToken.NumberLeft != 0)
                    gm.BlackToken.gameObject.SetActive(true);
                if (gm.WhiteToken.NumberLeft != 0)
                    gm.WhiteToken.gameObject.SetActive(true);
                if (gm.RedToken.NumberLeft != 0)
                    gm.RedToken.gameObject.SetActive(true);
                if (gm.BlueToken.NumberLeft != 0)
                    gm.BlueToken.gameObject.SetActive(true);
                if (gm.GreenToken.NumberLeft != 0)
                    gm.GreenToken.gameObject.SetActive(true);

                gm.player1.Points += CardPoints;
                switch (CardColor)
                {
                    case Colors.Color.Green:
                        gm.player1.GreenCards++;
                        break;
                    case Colors.Color.Black:
                        gm.player1.BlackCards++;
                        break;
                    case Colors.Color.Blue:
                        gm.player1.BlueCards++;
                        break;
                    case Colors.Color.Red:
                        gm.player1.RedCards++;
                        break;
                    case Colors.Color.White:
                        gm.player1.WhiteCards++;
                        break;
                }
            }
        }
    }
}
