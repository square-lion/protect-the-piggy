using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeBigScreen : MonoBehaviour {
	public int page;
	public GameObject displayScreen;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (FindObjectOfType<CostumeViewController> ().currentPage != page) {
			displayScreen.SetActive (true);
			gameObject.SetActive (false);

		}
	}
}
