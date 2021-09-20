using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public Text iphoneHighScoreText;
	public Text iphoneCoinText;
	public Text iphoneBillText;
	public Text ipadHighScoreText;
	public Text ipadCoinText;
	public Text ipadBillText;

	public string loadingScreen;

	public GameObject iphoneZombieBook;
	public GameObject ipadZombieBook;

	// Use this for initialization
	void Update () {
		iphoneHighScoreText.text = "High Score: " + PlayerPrefs.GetInt ("Highscore");
		iphoneCoinText.text = "" + PlayerPrefs.GetInt ("Coins");
		iphoneBillText.text = "" + PlayerPrefs.GetInt ("Bills");
		ipadHighScoreText.text = "High Score: " + PlayerPrefs.GetInt ("Highscore");
		ipadCoinText.text = "" + PlayerPrefs.GetInt ("Coins");
		ipadBillText.text = "" + PlayerPrefs.GetInt ("Bills");
	}
	public void GoToShop()
	{
		SceneManager.LoadScene (loadingScreen);
		PlayerPrefs.SetString("NextScene", "TouchScreenShop");
	}
	public void GoToCostumes()
	{
		SceneManager.LoadScene (loadingScreen);
		PlayerPrefs.SetString("NextScene", "TouchScreenCostumes");
	}
	public void GoToUpgrades()
	{
		SceneManager.LoadScene (loadingScreen);
		PlayerPrefs.SetString("NextScene", "TouchScreenUpgrades");
	}
	public void Play()
	{
		SceneManager.LoadScene (loadingScreen);
		PlayerPrefs.SetString("NextScene", "TouchScreenGame");
	}
	public void OpenZombieBook()
	{
		iphoneZombieBook.SetActive (true);
		ipadZombieBook.SetActive(true);
	}
	public void BookClose()
	{
		iphoneZombieBook.SetActive (false);
		ipadZombieBook.SetActive(false);
	}
	public void GoToLOL(){
		SceneManager.LoadScene (loadingScreen);
		PlayerPrefs.SetString("NextScene", "TouchScreenLeagueOfPigs");
	}
}
