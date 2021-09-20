using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour {


	private int coins;
	private int bills;
	public string loadingMenu;

	public int currentGun;
	public int currentKnife;

	public GameObject ipadGunScreen;
	public GameObject ipadKnifeScreen;
	public GameObject iphoneGunScreen;
	public GameObject iphoneKnifeScreen;

	public GameObject selectMenu;
	public GameObject mainMenu;
	public GameObject ipadSelectMenu;
	public GameObject ipadMainMenu;


	public bool[] boughtGuns;
	public bool[] boughtKnife;

	public Text ipadCoinText;
	public Text ipadBillsText;

	public Text iphoneCoinText;
	public Text iphoneBillText;
	// Use this for initialization
	void Start () {
		
		currentGun = PlayerPrefs.GetInt ("CurrentGun");
		currentKnife = PlayerPrefs.GetInt ("CurrentKnife");

	}
	void Update()
	{
		coins = PlayerPrefs.GetInt ("Coins");
		bills = PlayerPrefs.GetInt("Bills");

		ipadCoinText.text = "" + coins;
		iphoneCoinText.text = "" + coins;

		ipadBillsText.text = "" + bills;
		iphoneBillText.text = "" + bills;
	}
	public void SpendCoins(int cost)
	{
		coins -= cost;
	}
	public void SetCurrentGun(int gunID, int cost)
	{
			PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins")- cost);
			currentGun = gunID;
			PlayerPrefs.SetInt ("CurrentGun", gunID);
			WeoponChange();
		
	}
	public void SetCurrentKnife(int knifeID, int cost)
	{
			coins -= cost;
			currentKnife = knifeID;
			PlayerPrefs.SetInt ("CurrentKnife", knifeID);
			WeoponChange();
		
	}
	public void Back()
	{
		SceneManager.LoadScene (loadingMenu);
		PlayerPrefs.SetString("NextScene", "TouchScreenMenu");
	}
	public void WeoponChange()
	{
		selectMenu.SetActive(false);
		mainMenu.SetActive(true);
		ipadSelectMenu.SetActive(false);
		ipadMainMenu.SetActive(true);
	}
}