using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
	public bool isYourTurn;

	public int yourTurn;

	public int yourOpponentTurn;

	public Text turnText;

	
	// Start is called before the first frame update
    void Start()
	{
		isYourTurn = true;
		yourTurn = 1;
		yourOpponentTurn = 0;
	}

    // Update is called once per frame
    void Update()
    {
		if (isYourTurn == true)
		{
			turnText.text = "My turn";
		}
		else
		{
			turnText.text = "Opponent turn";
		}
	}

	public void EndYourTurn()
	{
		isYourTurn = false;
		yourOpponentTurn += 1;
	}

	public void EndOpponentTurn()
	{
		isYourTurn = true;
		yourTurn += 1;
	}
}
