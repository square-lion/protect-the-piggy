using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscores : MonoBehaviour {
	const string privateCode = "wg4ICrbB80uoj2UphoMTTAuKX6xFZqFEy7frLICqBoMw";
	const string publicCode = "59933b0a958b94190c4d5cbe";
	const string webURl = "http://dreamlo.com/lb/";

	public Sprite[] Pigs;
	public Highscore[] highscoresList;
	DisplayHighscores highscoresDisplay;
	void Start()
	{ 
		highscoresDisplay = GetComponent<DisplayHighscores>();
	}
	
	public void AddNewHighScore(string username, int score){
		StartCoroutine(UploadNewHighscore(username,score)); 
	}
	
	IEnumerator UploadNewHighscore(string username, int score)
	{
		WWW www = new WWW(webURl + privateCode + "/add/" + WWW.EscapeURL(username + "/" + score));
		yield return www;

		if(string.IsNullOrEmpty(www.error))
		{
			print("Upload Successful");
		}
		else
		{
			print("Error uploader" + www.error);
		}
	}
	public void DownloadHighScores()
	{
		StartCoroutine("DownloadHighScoresFromDatabase");
	}

	IEnumerator DownloadHighScoresFromDatabase()
		{
			WWW www = new WWW(webURl + publicCode +  "/pipe/");
			yield return www;
			if(string.IsNullOrEmpty(www.error))
			{
				FormatHighscores(www.text);
				highscoresDisplay.OnHighscoresDownloaded(highscoresList);
			}
			else
			{
				print(www.error);
			}
		}
	void FormatHighscores(string textStream)
	{
		string[] entries = textStream.Split(new char[] {'\n'}, System.StringSplitOptions .RemoveEmptyEntries);
		highscoresList = new Highscore[entries.Length];

		for (int i = 0; i <entries.Length; i++)
		{
			string[] entryInfo = entries[i].Split(new char[] {'|'});
			string username = entryInfo[0];
			int score = int.Parse(entryInfo[1]);
			highscoresList[i] = new Highscore(username,score);
			//print (highscoresList[i].username + ": " + highscoresList[i].score);
		}
	}
}
public struct Highscore {
	public string username;
	public int score;

	public Highscore(string _username, int _score)
	{
	username = _username;
	score = _score;
	}
}
