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
    public int CardColor { get; set; }
    public int CardCostBlack { get; set; }
    public int CardCostWhite { get; set; }
    public int CardCostRed { get; set; }
    public int CardCostBlue { get; set; }
    public int CardCostGreen { get; set; }

    public int CardPoints { get; set; }

    public Card(string color, int points, int costblck, int costwhite, int costred, int costblue, int costgreen)
    {
        CardColor = (int)Enum.Parse(typeof(CardTypes.CardColor), color);
        CardCostBlack = costblck;
        CardCostWhite = costwhite;
        CardCostRed = costred;
        CardCostBlue = costblue;
        CardCostGreen = costgreen;
        CardPoints = points;
    }
}
