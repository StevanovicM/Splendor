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
            if (CardCostBlack <= gm.GetPlayer().BlackTokens + gm.GetPlayer().BlackCards && CardCostWhite <= gm.GetPlayer().WhiteTokens + gm.GetPlayer().WhiteCards &&
                CardCostRed <= gm.GetPlayer().RedTokens + gm.GetPlayer().RedCards && CardCostBlue <= gm.GetPlayer().BlueTokens + gm.GetPlayer().BlueCards &&
                CardCostGreen <= gm.GetPlayer().GreenTokens + gm.GetPlayer().GreenCards && !gm.GetPlayer().PlayedCard && !gm.GetPlayer().TookTokens)
			{
				// Move card to available card slot
				int index = -1;
				switch (CardColor)
				{
                    case Colors.Color.Green:
						index = gm.FirstAvailableSlot(Colors.Color.Green);
						gameObject.transform.position = gm.GetPlayer().GreenCardSlots[index].position;
						gm.GetPlayer().GreenCardSlotsAvailable[index] = true;
						break;
                    case Colors.Color.Black:
						index = gm.FirstAvailableSlot(Colors.Color.Black);
						gameObject.transform.position = gm.GetPlayer().BlackCardSlots[index].position;
						gm.GetPlayer().BlackCardSlotsAvailable[index] = true;
						break;
                    case Colors.Color.Blue:
						index = gm.FirstAvailableSlot(Colors.Color.Blue);
						gameObject.transform.position = gm.GetPlayer().BlueCardSlots[index].position;
						gm.GetPlayer().BlueCardSlotsAvailable[index] = true;
						break;
					case Colors.Color.Red:
						index = gm.FirstAvailableSlot(Colors.Color.Red);
						gameObject.transform.position = gm.GetPlayer().RedCardSlots[index].position;
						gm.GetPlayer().RedCardSlotsAvailable[index] = true;
						break;
					case Colors.Color.White:
						index = gm.FirstAvailableSlot(Colors.Color.White);
						gameObject.transform.position = gm.GetPlayer().WhiteCardSlots[index].position;
						gm.GetPlayer().WhiteCardSlotsAvailable[index] = true;
						break;
				}
                // move to card to slot
                //this.gameObject.transform.position = gm.player1CardSlots[index].position;
                //            gm.availableCardSlotsPlayer1[index] = true;

				// Replace cards
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
                int tmpCardCostBlack = CardCostBlack - gm.GetPlayer().BlackCards;
                int tmpCardCostWhite = CardCostWhite - gm.GetPlayer().WhiteCards;
                int tmpCardCostRed   = CardCostRed - gm.GetPlayer().RedCards;
                int tmpCardCostBlue  = CardCostBlue - gm.GetPlayer().BlueCards;
                int tmpCardCostGreen = CardCostGreen - gm.GetPlayer().GreenCards;

                // tmp cost could be less than zero if the player has more than needed cards
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


                // use the tokens if there is not enough only cards, for loop to get back all the tokens spent

                if (tmpCardCostBlack > 0)
                {
                    for (int i = 0; i < tmpCardCostBlack; i++)
                    {
                        gm.GetPlayer().BlackTokens--;
                        int blackIndex = gm.FirstNotAvailableToken(Colors.Color.Black);
                        gm.BlackTokens[blackIndex].transform.position = gm.blackTokenSlot.position + new Vector3(((gm.BlackOffset + (float)0.3)*blackIndex), 0 , 0);
                        gm.BlackTokens[blackIndex].Available = true;
                        gm.BlackTokens[blackIndex].InPossession = null;
                        //gm.BlackToken.NumberLeft += tmpCardCostBlack;
                    }
                }

                if (tmpCardCostWhite > 0)
                {
                    for (int i = 0; i < tmpCardCostWhite; i++)
                    {
                        gm.GetPlayer().WhiteTokens--;
                        int whiteIndex = gm.FirstNotAvailableToken(Colors.Color.White);
						gm.WhiteTokens[whiteIndex].transform.position = gm.whiteTokenSlot.position + new Vector3(((gm.WhiteOffset + (float)0.3) * whiteIndex), 0, 0);
						gm.WhiteTokens[whiteIndex].Available = true;
                        gm.WhiteTokens[whiteIndex].InPossession = null;
                        //gm.WhiteToken.NumberLeft += tmpCardCostWhite;
                    }
                }

                if (tmpCardCostRed > 0)
                {
                    for (int i = 0; i < tmpCardCostRed; i++)
                    {
                        gm.GetPlayer().RedTokens--;
                        int redIndex = gm.FirstNotAvailableToken(Colors.Color.Red);
						gm.RedTokens[redIndex].transform.position = gm.redTokenSlot.position + new Vector3(((gm.RedOffset + (float)0.3) * redIndex), 0, 0);
						gm.RedTokens[redIndex].Available = true;
                        gm.RedTokens[redIndex].InPossession = null;
                        // gm.RedToken.NumberLeft += tmpCardCostRed;
                    }
                }

                if (tmpCardCostBlue > 0)
                {
                    for (int i = 0; i < tmpCardCostBlue; i++)
                    {
                        gm.GetPlayer().BlueTokens--;
                        int blueIndex = gm.FirstNotAvailableToken(Colors.Color.Blue);
						gm.BlueTokens[blueIndex].transform.position = gm.blueTokenSlot.position + new Vector3(((gm.BlueOffset + (float)0.3) * blueIndex), 0, 0);
						gm.BlueTokens[blueIndex].Available = true;
                        gm.BlueTokens[blueIndex].InPossession = null;
                        // gm.BlueToken.NumberLeft += tmpCardCostBlue;
                    }
                }

                if (tmpCardCostGreen > 0)
                {
                    for (int i = 0; i < tmpCardCostGreen; i++)
                    {
                        gm.GetPlayer().GreenTokens--;
                        int greenIndex = gm.FirstNotAvailableToken(Colors.Color.Green);
						gm.GreenTokens[greenIndex].transform.position = gm.greenTokenSlot.position + new Vector3(((gm.GreenOffset + (float)0.3) * greenIndex), 0, 0);
						gm.GreenTokens[greenIndex].Available = true;
                        gm.GreenTokens[greenIndex].InPossession = null;
                        //  gm.GreenToken.NumberLeft += tmpCardCostGreen;
                    }
                }


                //if(gm.BlackToken.NumberLeft != 0)
                //    gm.BlackToken.gameObject.SetActive(true);
                //if (gm.WhiteToken.NumberLeft != 0)
                //    gm.WhiteToken.gameObject.SetActive(true);
                //if (gm.RedToken.NumberLeft != 0)
                //    gm.RedToken.gameObject.SetActive(true);
                //if (gm.BlueToken.NumberLeft != 0)
                //    gm.BlueToken.gameObject.SetActive(true);
                //if (gm.GreenToken.NumberLeft != 0)
                //    gm.GreenToken.gameObject.SetActive(true);


                // increase the player points and card count
                gm.GetPlayer().Points += CardPoints;
                switch (CardColor)
                {
                    case Colors.Color.Green:
                        gm.GetPlayer().GreenCards++;
                        break;
                    case Colors.Color.Black:
                        gm.GetPlayer().BlackCards++;
                        break;
                    case Colors.Color.Blue:
                        gm.GetPlayer().BlueCards++;
                        break;
                    case Colors.Color.Red:
                        gm.GetPlayer().RedCards++;
                        break;
                    case Colors.Color.White:
                        gm.GetPlayer().WhiteCards++;
                        break;
                }

				gm.GetPlayer().PlayedCard = true;
			}
        }
    }
}
