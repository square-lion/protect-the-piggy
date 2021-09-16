using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour {

	public AudioSource pigDeath;
	public AudioSource pigSnort;
	public AudioSource Music;

	public GameObject Pig;
	public float snortDelay;
	public float currentDelay;

	public bool startOfGame;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("Music") == 0)
			Music.Play();

		Invoke ("notStart", 2f);

		startOfGame = true;

		currentDelay = snortDelay;
	}
	
	// Update is called once per frame
	void Update () {
			currentDelay -= Time.deltaTime;
		
		if (currentDelay <= 0 && PlayerPrefs.GetInt("Music") == 0) {
			
			currentDelay = snortDelay;
			pigSnort.Play ();
		}

	}
	public void notStart()
	{
		startOfGame = false;
	}
}
