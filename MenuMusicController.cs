using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusicController : MonoBehaviour {

	public GameObject MenuMusic;
	public  Scene currentScene;
	// Use this for initialization
	void Start () {
		if(FindObjectOfType<DontDestroyOnLoad>() == null)
			Instantiate(MenuMusic, transform.position, transform.rotation);
	
		if(PlayerPrefs.GetInt("Music") == 0 && !FindObjectOfType<DontDestroyOnLoad>().GetComponent<AudioSource>().isPlaying)
		{
			FindObjectOfType<DontDestroyOnLoad>().GetComponent<AudioSource>().Play();
		}
	}
	// Update is called once per frame
	void Update () {
		 currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "TouchScreenGame") {
			MenuMusic.SetActive (false);
		}
	}
}
