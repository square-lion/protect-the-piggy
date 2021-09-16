using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsFromCrateUpgrade : MonoBehaviour {

	public int UpgradeID;
	public GameObject[] boughtDots;
	public int nextUpgrade;
	public int upgradesBought;
	public int[] prices;
	public bool[] boughtUpgrades;
	public Text priceText;

	// Use this for initialization
	void Start () {
		upgradesBought = PlayerPrefs.GetInt ("AddedHealth");
		nextUpgrade = upgradesBought + 1;
	}

	// Update is called once per frame
	void Update () {
		if(nextUpgrade < prices.Length)
			priceText.text = prices [nextUpgrade] + " Coins";

		if (nextUpgrade >= prices.Length) {
			priceText.text = "maxed";
		}


		if (upgradesBought >= 1) {
			boughtDots [0].SetActive (true);
		} else {
			boughtDots [0].SetActive (false);
		}
		if (upgradesBought >= 2) {
			boughtDots [1].SetActive (true);
		} else {
			boughtDots [1].SetActive (false);
		}
	}
	public void BuyUpgrade()
	{
		if (prices [nextUpgrade] <= PlayerPrefs.GetInt ("Coins") && nextUpgrade <= boughtDots.Length) {
			boughtUpgrades [upgradesBought] = true;
			PlayerPrefs.SetInt ("AddedHealth", PlayerPrefs.GetInt ("AddedHealth") + 1);
			PlayerPrefs.SetInt ("Coins", PlayerPrefs.GetInt ("Coins") - prices [nextUpgrade]);
			nextUpgrade++;
			upgradesBought++;
		}
	}
}