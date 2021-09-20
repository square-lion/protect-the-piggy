using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOverScreen : MonoBehaviour {

	public string retry;

	public Text coins;
	public Text bills;
	private bool done = false;
	
	void Update()
	{
		coins.text = "" + PlayerPrefs.GetInt ("Coins");
		bills.text = "" + PlayerPrefs.GetInt ("Bills");

		if(!done)
		{
			FindObjectOfType<MoneyManager>().AddMoney(FindObjectOfType<ScoreController>().score);
			done = true;
		}
	}

	public void Menu()
	{
		Time.timeScale = 1f;
		PlayerPrefs.SetString("NextScene", "TouchScreenMenu");
		SceneManager.LoadScene ("TouchScreenLoadingScreen");
	}
	public void Retry()
	{
		SceneManager.LoadScene (retry);	
	}
}
