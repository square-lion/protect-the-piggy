using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

	public GameObject Menu;

	public string MainMenu;
	// Use this for initialization
	void Start () {
		Menu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Escape)) {
			if(Menu.activeSelf)
				Menu.SetActive (false);
			Time.timeScale = 1;
		}
		if (Input.GetKey (KeyCode.Escape)) {
			if (!Menu.activeSelf && !LevelController.gameOver) {
				Time.timeScale = 0;
				Menu.SetActive (true);
			}
		}
	}
	public void Resume()
	{
		Menu.SetActive (false);
		Time.timeScale = 1;
	}
	public void Quit()
	{
		Time.timeScale = 1;
		PlayerPrefs.SetString("NextScene", "TouchScreenMenu");
		SceneManager.LoadScene ("TouchScreenLoadingScreen");
	}
	public void PauseTouch()
	{
		Menu.SetActive (true);
		Time.timeScale = 0;
	}
}
