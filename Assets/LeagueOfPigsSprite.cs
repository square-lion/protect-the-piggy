using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeagueOfPigsSprite : MonoBehaviour {

	private Image sprites;
	private Text scoreText;
	private Highscores highscores;
	private int score;

	// Use this for initialization
	void Update () {
		highscores = FindObjectOfType<Highscores>();
		sprites = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
		scoreText = this.gameObject.transform.GetChild(1).gameObject.GetComponent<Text>();
		score = int.Parse(scoreText.text);

		if(score >= 350)
			sprites.sprite = highscores.Pigs[7];
		else if(score >= 300)
			sprites.sprite = highscores.Pigs[6];
		else if(score >= 250)
			sprites.sprite = highscores.Pigs[5];
		else if(score >= 200)
			sprites.sprite = highscores.Pigs[4];
		else if(score >= 150)
			sprites.sprite = highscores.Pigs[3];
		else if(score >= 100)
			sprites.sprite = highscores.Pigs[2];
		else if(score >= 50)
			sprites.sprite = highscores.Pigs[1];
		else if(score >= 0)
			sprites.sprite = highscores.Pigs[0];
	}
	
}
