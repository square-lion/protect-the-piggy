using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeViewController : MonoBehaviour {

	public GameObject[] pages;
	public int currentPage;
	public GameObject leftArrow;
	public GameObject rightArrow;
	// Use this for initialization
	void Start () {
		currentPage = 1;
	}
	
	// Update is called once per frame
	void Update () {

		if (currentPage == 1) {
			leftArrow.SetActive (false);
		} else
			leftArrow.SetActive (true);
		if (currentPage == pages.Length) {
			rightArrow.SetActive (false);
		} else
			rightArrow.SetActive (true);

	}
	public void GoLeft()
	{
		if (currentPage != 1) {
			currentPage--;
		}
	}
	public void GoRight()
	{
		if (currentPage != pages.Length) {
			currentPage++;
		}
	}
}
