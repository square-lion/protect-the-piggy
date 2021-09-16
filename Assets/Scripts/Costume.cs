using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Costume : MonoBehaviour {
	public bool alreadyBought = true;
	public int CostumeID;
	public bool Player;
	public bool Pig;
	public GameObject equipButton;
	public GameObject equipedButton;
	public GameObject bigScreen;
	public GameObject displayScreen;
	private CustumeMenuController c;
	// Use this for initialization
	void Start () {
		c = FindObjectOfType<CustumeMenuController>();

		equipButton.SetActive (true);
		equipedButton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (PlayerPrefs.GetInt ("DisplayCostume") != CostumeID) {
			bigScreen.SetActive (false); 
		} 

		if (Player) {
			if (PlayerPrefs.GetInt ("PlayerCostume") == CostumeID) {
				c.currentPlayerCostume = c.PlayerCostumes [CostumeID];
				equipedButton.SetActive (true);
				equipButton.SetActive (false);

			} else{
				equipedButton.SetActive (false);
				equipButton.SetActive (true);
		}
		if (Pig) {
			if (PlayerPrefs.GetInt ("PigCostume") == CostumeID) {
				c.currentPigCostume = c.PigCostumes [CostumeID];
				equipedButton.SetActive (true);
				equipButton.SetActive (false);

			} else{
				equipedButton.SetActive (false);
				equipButton.SetActive (true);
			}
		}
	}	
	}
	public void AcheviementUnlocked()
	{
		if (Player) {
			c.boughtPlayerCostumes [CostumeID] = true;
		}
		if (Pig) {
			c.boughtPigCostumes [CostumeID] = true;
		}
	}
	public void Equip()
	{
		if (Player) {
			c.currentPlayerCostumeNumber = CostumeID;
			PlayerPrefs.SetInt ("PlayerCostume", CostumeID);
			PlayerPrefs.SetInt ("BoughtPl" + CostumeID, 1);
			bigScreen.SetActive (false);
			displayScreen.SetActive (true);
		}
		if (Pig) {
			c.currentPigCostumeNumber = CostumeID;
			PlayerPrefs.SetInt ("PigCostume", CostumeID);
			PlayerPrefs.SetInt ("BoughtPi" + CostumeID, 1);
			bigScreen.SetActive (false);
			displayScreen.SetActive (true);
		}
	}
	public void Clicked()
	{
		if (!bigScreen.activeInHierarchy) {
			PlayerPrefs.SetInt ("DisplayCostume", CostumeID);
			displayScreen.SetActive (false);
			bigScreen.SetActive (true);
		} else {
			displayScreen.SetActive (true);
			bigScreen.SetActive (false);
		}
	}
}
