using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialText : MonoBehaviour {

	public GameObject nextMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Back()
	{
		nextMenu.SetActive(true);
	}
}
