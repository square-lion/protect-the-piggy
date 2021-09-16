using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopItem : MonoBehaviour {

	public int GunID;
	public int Cost;
	public int BillsCost;
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
		equipButton = BigScreen.transform.GetChild(1).gameObject;
		equipedButton = BigScreen.transform.GetChild(2).gameObject;
		buyButton = BigScreen.transform.GetChild(3).gameObject;
		buyNowButton = BigScreen.transform.GetChild(4).gameObject;
		BigScreen.SetActive (false);
		shop = FindObjectOfType<ShopController> ();

		if (GunID == shop.currentGun || PlayerPrefs.GetInt ("gun" + GunID) == 1 || GunID == 0) {
				Unlock();
		}
		 else {
			Bought = false;
			Lock.SetActive (true);
			buyButton.SetActive (true);
			buyNowButton.SetActive (true);
			equipButton.SetActive (false);
			equipedButton.SetActive (false);
			shop.boughtGuns [GunID] = false;
			PlayerPrefs.SetInt("gun" + GunID, 0);
		}
	
			

		shop = FindObjectOfType<ShopController> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (GunID == shop.currentGun) {
			shop.boughtGuns [GunID] = true;
			Bought = true;
			Lock.SetActive (false);
			buyButton.SetActive (false);
			buyNowButton.SetActive (false);
			BigScreen.SetActive (true);
			equipButton.SetActive (false);
			equipedButton.SetActive (true);
			PlayerPrefs.SetInt ("gun" + GunID, 1);
		}	else if (shop.boughtGuns [GunID] && GunID != shop.currentGun) {
			equipButton.SetActive (true);
			equipedButton.SetActive (false);
		}



		if (PlayerPrefs.GetInt ("BigGun") != GunID)
			BigScreen.SetActive (false);


	}
		
	public void Clicked()
	{
		PlayerPrefs.SetInt ("BigGun", GunID);
		BigScreen.SetActive (true);
	}
	public void Unlock()
	{
		shop.boughtGuns [GunID] = true;
			Bought = true;
			Lock.SetActive (false);
			buyButton.SetActive (false);
			buyNowButton.SetActive (false);
			BigScreen.SetActive (true);
			equipButton.SetActive (false);
			equipedButton.SetActive (true);
			PlayerPrefs.SetInt("gun" + GunID, 1);
	}
	public void Equip()
	{
		shop.SetCurrentGun (GunID, 0);
		equipButton.SetActive (false);
		equipedButton.SetActive (true);
		shop.WeoponChange();
	}
	public void Buy()
	{
			if (PlayerPrefs.GetInt ("Coins") >= Cost) {
			PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins") - Cost); 
			shop.SetCurrentGun (GunID, 0);
			//Debug.Log("Bought for " + GunID);
		}
	}
	public void BuyNow()
	{
		if (PlayerPrefs.GetInt ("Bills") >= BillsCost) {
			shop.SetCurrentGun (GunID, 0);
			PlayerPrefs.SetInt ("Bills", PlayerPrefs.GetInt ("Bills") - BillsCost); 
		}
	
	}
}
