using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPage : MonoBehaviour {
	public int pageSpread;
	public BookController book;
	public GameObject page;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (pageSpread == book.page)
			page.SetActive (true);
		else
			page.SetActive (false);
	}
}
