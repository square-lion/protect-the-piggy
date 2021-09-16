using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public int highScore;

	private ScoreController sc; 

	public Text iphoneHighScoreText;
	public Text ipadHighScoreText;
	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt ("Highscore");
		highScore = PlayerPrefs.GetInt ("Highscore");
		sc = FindObjectOfType<ScoreController> ();
	}
	
	// Update is called once per frame
	void Update () {
		iphoneHighScoreText.text = "Highscore: " + highScore;
		ipadHighScoreText.text = "Highscore: " + highScore;

		if (sc.score > highScore) {
		
			highScore = sc.score;
			PlayerPrefs.SetInt ("Highscore", sc.score);
		}
	}



}
