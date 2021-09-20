using UnityEngine;
using System.Collections;

public class PigController : MonoBehaviour {

	public int Health;
	public Sprite currentSpite;
	public Sprite[] sprites;
	private SpriteRenderer sp;
	public AudioSource ad;
	public ScoreController s;
	public static bool died;
	// Use this for initializatin
	void Start () {
		sp = GetComponent<SpriteRenderer> ();
		currentSpite = sprites [PlayerPrefs.GetInt ("PigCostume")];
		sp.sprite = currentSpite;
	}
	
	// Update is called once per frame
	void Update () {

		if (Health <= 0 && !died) {
			died = true;
			ad.Play ();
			GetComponent<SpriteRenderer>().enabled = false;


		}
	}
	public void TakeHealth()
			{
		Health = 0;

			}
}

