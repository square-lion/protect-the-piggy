using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegueOfPigsCostume : MonoBehaviour {

	public int CostumeID;
	public string IdName;

	private GameObject equipButton;
	private GameObject equipedButton;
	public GameObject bigScreen;
	private GameObject displayScreen;
	private CustumeMenuController c;
	// Use this for initialization
	void Start () {
		equipButton = bigScreen.gameObject.transform.GetChild(2).gameObject;
		equipedButton = bigScreen.gameObject.transform.GetChild(1).gameObject;
		if(PlayerPrefs.GetInt(IdName) != 1){
			equipButton.SetActive(false);
			equipedButton.SetActive(false);
		}
		else{	
					equipButton.SetActive (true);
			equipedButton.SetActive (false);
		}
		displayScreen = GameObject.FindGameObjectWithTag("Display");

		c = FindObjectOfType<CustumeMenuController>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (PlayerPrefs.GetInt ("DisplayCostume") != CostumeID) {
			bigScreen.SetActive (false); 
		} 
			if(PlayerPrefs.GetInt(IdName) == 1){
			if (PlayerPrefs.GetInt ("PigCostume") == CostumeID) {
				c.currentPigCostume = c.PigCostumes [CostumeID];
				equipedButton.SetActive (true);
				equipButton.SetActive (false);
			} else{
				equipedButton.SetActive (false);
				equipButton.SetActive (true);
			}	
			}else{
				equipButton.SetActive(false);
			equipedButton.SetActive(false);
			}
	}	
	public void AcheviementUnlocked()
	{
		if(PlayerPrefs.GetString(IdName) == "" + 1)
			c.boughtPigCostumes [CostumeID] = true;
	}
	public void Equip()
	{
			c.currentPigCostumeNumber = CostumeID;
			PlayerPrefs.SetInt ("PigCostume", CostumeID);
			PlayerPrefs.SetInt ("BoughtPi" + CostumeID, 1);
			bigScreen.SetActive (false);
			displayScreen.SetActive (true);
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
