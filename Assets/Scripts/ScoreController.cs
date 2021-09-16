using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public Text iphoneScoreText;
	public Text ipadScoreText;
	public int score;

	private MoneyManager m;

	// Use this for initialization
	void Start () {
		m = FindObjectOfType<MoneyManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		iphoneScoreText.text = "" + score;
		ipadScoreText.text = "" + score;
	}
	public void AddToScore(int pointsOnDeath)
	{
		score += pointsOnDeath;
	}
	public void gameIsOver()
	{
		m.AddMoney (score);
	}
}
