using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
	public GameObject Options;
	public void PlayGame()
	{
		gameObject.SetActive(false);
		Options.gameObject.SetActive(true);
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
