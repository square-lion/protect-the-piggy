using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookController : MonoBehaviour {

	public GameObject[] pages;
	public int page;
	public GameObject leftArrow;
	public GameObject rightArrow;
	// Use this for initialization
	void Start () {
		page = 2;
		leftArrow.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		if (page == 2) 
			leftArrow.SetActive (false);
		 else
			leftArrow.SetActive (true);

		if (page == pages.Length)
			rightArrow.SetActive (false);
		else
			rightArrow.SetActive (true);


	}
	public void TurnPageRight()
	{
		page += 2;
	}
	public void TurnPageeLeft()
	{
		page -= 2;
	}
}
