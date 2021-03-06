using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
	public GameObject MainMenu;
	public TMPro.TMP_InputField Player1InputField;
	public TMPro.TMP_InputField Player2InputField;
	public TMPro.TMP_InputField Player3InputField;
	public TMPro.TMP_InputField Player4InputField;
	public static bool Player1Active;
	public static bool Player2Active;
	public static bool Player3Active;
	public static bool Player4Active;
	public Toggle Player1Toggle;
	public Toggle Player2Toggle;
	public Toggle Player3Toggle;
	public Toggle Player4Toggle;
	public static string Player1Name;
	public static string Player2Name;
	public static string Player3Name;
	public static string Player4Name;
    public GameObject errorPanel;

    private void Update()
    {
        _ = Player1Toggle.isOn
            ? Player1InputField.interactable = true
            : Player1InputField.interactable = false;
        _ = Player2Toggle.isOn
            ? Player2InputField.interactable = true
            : Player2InputField.interactable = false;
        _ = Player3Toggle.isOn
            ? Player3InputField.interactable = true
            : Player3InputField.interactable = false;
        _ = Player4Toggle.isOn
            ? Player4InputField.interactable = true
            : Player4InputField.interactable = false;
	}
	public void PlayGame()
	{
		int playerCount = 0;
		if (Player1Toggle.isOn)
		{
			Player1Active = true;
			Player1Name = Player1InputField.text;
			playerCount++;
		}

		if (Player2Toggle.isOn)
		{
			Player2Active = true;
			Player2Name = Player2InputField.text;
			playerCount++;
		}

		if (Player3Toggle.isOn)
		{
			Player3Active = true;
			Player3Name = Player3InputField.text;
			playerCount++;
		}

		if (Player4Toggle.isOn)
		{
			Player4Active = true;
			Player4Name = Player4InputField.text;
			playerCount++;
		}

		if (playerCount >= 2)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
        else
        {
            errorPanel.gameObject.SetActive(true);
        }
	}

    public void RemoveErrorPanel()
    {
		errorPanel.gameObject.SetActive(false);
    }

	public void GoBack()
	{
		gameObject.SetActive(false);
		MainMenu.gameObject.SetActive(true);
	}
}

