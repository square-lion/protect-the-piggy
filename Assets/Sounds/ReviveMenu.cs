using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReviveMenu : MonoBehaviour {

	public Slider slider;
	public GameObject gameOverMenu;
	private float Delay = 5;
	private float currentDelay;
	public bool done;
	// Use this for initialization
	void Start () {
		currentDelay = Delay;
	}
	
	// Update is called once per frame
	void Update () {
		if(done)
			runOut();
		
		currentDelay -= Time.deltaTime;
		slider.value = currentDelay;

		if(currentDelay <= 0)
			runOut();
	}
	public void ViewAd()
	{
		done = true;
		currentDelay = 0;
		gameObject.SetActive(false);
	}
	void runOut()
	{
		gameOverMenu.SetActive(true);
		gameObject.SetActive(false);
	}
}
