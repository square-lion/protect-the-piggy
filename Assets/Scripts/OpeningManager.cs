using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ClickedAnywhere()
	{
		PlayerPrefs.SetString("NextScene", "TouchScreenMenu");
		SceneManager.LoadScene ("TouchScreenLoadingScreen");
	}
}
