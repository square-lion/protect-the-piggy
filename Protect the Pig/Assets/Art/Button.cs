using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

	public Sprite unpressed;
	public Sprite pressed;

	private Image im;
	void Start()
	{
		im = GetComponent<Image> ();
	}

	public void Press()
	{
		im.sprite = pressed;
	}
	public void UnPress()
	{
		im.sprite = unpressed;
	}
}
