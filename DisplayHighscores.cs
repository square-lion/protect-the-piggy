using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighscores : MonoBehaviour {


	public Text[] names;
	public Text[] scores;
	public Text highscoreText;

	Highscores highscoreManager;
	// Use this for initialization
	void Start () {
		highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");

		for(int i = 0; i < names.Length; i++)
		{
			names[i].text = "Fetching...";
			scores[i].text = "";
		}
		highscoreManager = GetComponent<Highscores>();
		StartCoroutine("RefreshHighscores");
	}
	public void OnHighscoresDownloaded(Highscore[] highscoreList)
	{
		for(int i = 0; i < names.Length; i++)
		{
			names[i].text = highscoreList[i].username;
			scores[i].text = "" + highscoreList[i].score;
		}
	}

	IEnumerator RefreshHighscores()
	{
		while(true)
		{
			highscoreManager.DownloadHighScores();
			yield return new WaitForSeconds(30f); 
		}
	}
}
