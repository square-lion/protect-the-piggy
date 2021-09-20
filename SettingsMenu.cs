using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour {

	public GameObject menu;
	public GameObject muteButton;
	public GameObject playButton;
	public GameObject credits;
	// Use this for initialization
	void Start () {
		menu.SetActive(false);

		if(PlayerPrefs.GetInt("Music") == 0)
		{
			playButton.SetActive(true);
			muteButton.SetActive(false);
		}
		else
		{
			muteButton.SetActive(true);
			playButton.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Clicked()
	{
		menu.SetActive(true);
	}
	public void MuteMusic()
	{
		PlayerPrefs.SetInt("Music", 1);
		FindObjectOfType<DontDestroyOnLoad>().GetComponent<AudioSource>().Stop();
		muteButton.SetActive(true);
		playButton.SetActive(false);
	}
	public void PlayMusic()
	{
		PlayerPrefs.SetInt("Music", 0);
		FindObjectOfType<DontDestroyOnLoad>().GetComponent<AudioSource>().Play();
		muteButton.SetActive(false);
		playButton.SetActive(true);
	}
	public void Back()
	{
	menu.SetActive(false);
	}
	public void CreditClick()
	{
		credits.SetActive(true);
	}
	public void CreditBack()
	{
		credits.SetActive(false);
	}	
}
