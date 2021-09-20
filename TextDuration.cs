using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDuration : MonoBehaviour {


	public float textDuration;
	private float currentDuration;

	private bool set;
	// Use this for initialization
	void Start () {
		currentDuration = textDuration;
	}
	
	// Update is called once per frame
	void Update () {

		currentDuration -= Time.deltaTime;

		if (currentDuration <= 0) {
			gameObject.SetActive (false);
			currentDuration = textDuration;
		
		}
	}
	
}
