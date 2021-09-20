using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeaderBoardController : MonoBehaviour {

	private Slider highscoreSlider;
	private int highscore;

	void Start () {
		highscore = PlayerPrefs.GetInt("Highscore");
		highscoreSlider = FindObjectOfType<Slider>();

		if(highscore > highscoreSlider.maxValue)
			highscore = (int)highscoreSlider.maxValue;

		highscoreSlider.value = highscore;
	
		//Sets all pigs to not unlocked
		PlayerPrefs.SetInt("LoP1", 1);
		PlayerPrefs.SetInt("LoP2", 0);
		PlayerPrefs.SetInt("LoP3", 0);
		PlayerPrefs.SetInt("LoP3", 0);
		PlayerPrefs.SetInt("LoP5", 0);
		PlayerPrefs.SetInt("LoP6", 0);
		PlayerPrefs.SetInt("LoP7", 0);
		PlayerPrefs.SetInt("LoP8", 0);
		//Checks to see what pigs are unlocked
		Debug.Log(highscore);
		if(highscore >= 50)
			PlayerPrefs.SetInt("LoP2", 1);
		if(highscore >= 100)
			PlayerPrefs.SetInt("LoP3", 1);
		if(highscore >= 150)
			PlayerPrefs.SetInt("LoP4", 1);
		if(highscore >= 200)
			PlayerPrefs.SetInt("LoP5", 1);
		if(highscore >= 250)
			PlayerPrefs.SetInt("LoP6", 1);
		if(highscore >= 300)
			PlayerPrefs.SetInt("LoP7", 1);
		if(highscore >= 350)
			PlayerPrefs.SetInt("LoP8", 1);
	}
	public void Back(){
		SceneManager.LoadScene("TouchScreenLoadingScreen");
		PlayerPrefs.SetString("NextScene", "TouchScreenMenu");
	}
}
