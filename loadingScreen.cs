using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingScreen : MonoBehaviour {

	public string[] tips;
	public Text tip;
	public Text loadingText;
	public float[] duration;
	private float currentDelay;
	// Use this for initialization
	void Start () {
		currentDelay = duration[Random.Range(0,duration.Length)];
		tip.text = tips[Random.Range(0,tips.Length)];

		InvokeRepeating("Loading", .5f, .5f);
	}
	
	// Update is called once per frame
	void Update () {
	currentDelay -= Time.deltaTime;
		if(currentDelay <= 0)
		{
			SceneManager.LoadScene(PlayerPrefs.GetString("NextScene"));
		}
	}
	public void Loading()
	{
		if(loadingText.text == "Loading."){
			loadingText.text = "Loading..";
			return;
		}

		if(loadingText.text == "Loading.."){
			loadingText.text = "Loading...";
			return;
		}

		if(loadingText.text == "Loading..."){
			loadingText.text = "Loading.";
			return;
		}
	}
}
