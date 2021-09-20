using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMainMenu : MonoBehaviour {

	public GameObject currentKnife;
	public GameObject currentGun;

	public GameObject[] guns;
	public GameObject[] knives;

	public GameObject SelectMenu;
	public GameObject KnifeMenu;
	public GameObject GunMenu;
	public Text knifeText;
	public Text gunText;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		currentGun = guns[PlayerPrefs.GetInt("CurrentGun")];
		currentKnife = knives[PlayerPrefs.GetInt("CurrentKnife")];
		foreach(GameObject g in guns)
		{
			g.SetActive(false);
		}
		foreach(GameObject k in knives)
		{
			k.SetActive(false);
		}
		knifeText.text = currentKnife.name + "";
		gunText.text = currentGun.name + "";
		currentGun.SetActive(true);
		currentKnife.SetActive(true);
	}
	public void KnifeClicked()
	{
		SelectMenu.SetActive(true);
		KnifeMenu.SetActive(true);
		GunMenu.SetActive(false);
		gameObject.SetActive(false);
	}
	public void GunClicked()
	{
		SelectMenu.SetActive(true);
		KnifeMenu.SetActive(false);
		GunMenu.SetActive(true);
		gameObject.SetActive(false);
	}
}
