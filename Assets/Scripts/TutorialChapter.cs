using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialChapter : MonoBehaviour {

	public GameObject pastMenu;

	 [Space(5)]
	 [Header("ONLY FOR MAIN MENU!")]
	public GameObject mainTutorial;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Back()
	{
		pastMenu.SetActive(true);
		gameObject.SetActive(false);
	}
	public void Close()
	{
		mainTutorial.SetActive(false);
	}
}
