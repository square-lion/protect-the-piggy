using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendHighscores : MonoBehaviour {

	public string userName;
	public int highscore;
	public GameObject selectName;
	private Highscores highscoreS;
	public bool reset;
	// Use this for initialization
	void Start () {
		if(reset){
			PlayerPrefs.SetInt("Highscore",0);
		}

		highscoreS = GetComponent<Highscores>();
		userName = PlayerPrefs.GetString("Username");
		highscore = PlayerPrefs.GetInt("Highscore");

		if(userName == "")
		{
			selectName.SetActive(true);
		}
		else
		{
			SetName();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Finish()
	{
		userName = selectName.gameObject.transform.GetChild(0).GetComponent<InputField>().text;
		PlayerPrefs.SetString("Username", userName);
		selectName.SetActive(false);
		SetName();
		
	}
	void SetName()
	{
		highscoreS.AddNewHighScore(userName, highscore);
	}
}
