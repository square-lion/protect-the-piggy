using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChange : MonoBehaviour {

	public Sprite normal;
	public Sprite clicked;
	
	public void Down()
	{
		GetComponent<Image>().sprite = clicked;
	}
	public void Up()
	{
		GetComponent<Image>().sprite= normal;
	}
}
