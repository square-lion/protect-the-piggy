﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusicContoller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(FindObjectOfType<DontDestroyOnLoad>() != null)
		FindObjectOfType<DontDestroyOnLoad> ().GetComponent<AudioSource> ().Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
