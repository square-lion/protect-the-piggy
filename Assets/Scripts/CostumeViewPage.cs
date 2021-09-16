using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeViewPage : MonoBehaviour {
	public int page;
	public CostumeViewController c;
	public GameObject content;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (c.currentPage == page) {
			content.SetActive (true);
		} else {
			content.SetActive (false);
		}
	}
}
