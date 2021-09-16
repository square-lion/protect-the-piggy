using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopKnife : MonoBehaviour  {

	public int KnifeID;
	public int Cost;
	public int BillCost;
	public bool Bought;
	public GameObject Lock;
	public bool selected;
	public GameObject BigScreen;
	private GameObject equipButton;
	private GameObject equipedButton;
	private GameObject buyButton;
	private GameObject buyNowButton;

	private ShopController shop;

	// Use this for initialization
	void Start () {
		BigScreen.SetActive (false);
		shop = FindObjectOfType<ShopController> ();

		equipButton = BigScreen.transform.GetChild(1).gameObject;
		equipedButton = BigScreen.transform.GetChild(2).gameObject;
		buyButton = BigScreen.transform.GetChild(3).gameObject;
		buyNowButton = BigScreen.transform.GetChild(4).gameObject;


		if (KnifeID == shop.currentKnife) {
			BigScreen.SetActive (true);
			shop.boughtKnife [KnifeID] = true;
			Bought = true;
			Lock.SetActive (false);
			buyButton.SetActive (false);
			buyNowButton.SetActive (false);
			equipButton.SetActive (false);
			equipedButton.SetActive (true);
			PlayerPrefs.SetInt ("Knife" + KnifeID, 1);
		}
		if (PlayerPrefs.GetInt ("Knife" + KnifeID) == 1 && KnifeID != shop.currentKnife || KnifeID == 0) {
			Bought = true;
			Lock.SetActive (false);
			buyButton.SetActive (false);
			buyNowButton.SetActive (false);
			equipButton.SetActive (true);
			equipedButton.SetActive (false);
			shop.boughtKnife [KnifeID] = true;
		} else {
			Bought = false;
			Lock.SetActive (true);
			buyButton.SetActive (true);
			buyNowButton.SetActive (true);
			equipButton.SetActive (false);
			equipedButton.SetActive (false);
			shop.boughtKnife [KnifeID] = false;
		}



		shop = FindObjectOfType<ShopController> ();
	}

	// Update is called once per frame
	void Update () {

		if (KnifeID == shop.currentKnife) {
			shop.boughtKnife [KnifeID] = true;
			Bought = true;
			Lock.SetActive (false);
			buyButton.SetActive (false);
			buyNowButton.SetActive (false);
			BigScreen.SetActive (true);
			equipButton.SetActive (false);
			equipedButton.SetActive (true);
			PlayerPrefs.SetInt ("Knife" + KnifeID, 1);
		} 
		else if (shop.boughtKnife [KnifeID] && KnifeID != shop.currentKnife) {
			equipButton.SetActive (true);
			equipedButton.SetActive (false);
		}


		if (PlayerPrefs.GetInt ("BigKnife") != KnifeID)
			BigScreen.SetActive (false);


	}

	public void Clicked()
	{
		PlayerPrefs.SetInt ("BigKnife", KnifeID);
		BigScreen.SetActive (true);
	}
	public void Equip()
	{
		shop.SetCurrentKnife (KnifeID, 0);
		equipButton.SetActive (false);
		equipedButton.SetActive (true);
		shop.WeoponChange();
	}
	public void Buy()
	{
		if (PlayerPrefs.GetInt ("Coins") >= Cost) {
			PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins") - Cost); 
			shop.SetCurrentKnife (KnifeID, 0);
			//Debug.Log(Cost + " Yes");
		}

	}
	public void BuyNow()
	{
		if (PlayerPrefs.GetInt ("Bills") >= BillCost) {
			shop.SetCurrentKnife (KnifeID, 0);
			PlayerPrefs.SetInt ("Bills", PlayerPrefs.GetInt ("Bills") - BillCost); 
		}
	}
}
