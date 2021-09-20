using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustumeMenuController : MonoBehaviour {
	public Sprite[] PlayerCostumes;
	public Sprite[] PigCostumes;
	public Sprite currentPlayerCostume;
	public Sprite currentPigCostume;
	public GameObject iphonePlayerCostumeHolder;
	public GameObject iphonePigCostumeHolder;
	public GameObject ipadPlayerCostumeHolder;
	public GameObject ipadPigCostumeHolder;
	public GameObject iphonePlayerCostumeView;
	public GameObject iphonePigCostumeView;
	public GameObject iphoneSpecialCostumeView;
	public GameObject ipadPlayerCostumeView;
	public GameObject ipadPigCostumeView;
	public GameObject ipadSpecialCostumeView;
	public GameObject iphoneDisplayView;
	public GameObject ipadDisplayView;
	public int currentPlayerCostumeNumber;
	public int currentPigCostumeNumber;
	public bool[] boughtPlayerCostumes;
	public bool[] boughtPigCostumes;
	public bool[] boughtSpecialCostumes;

	// Use this for initialization
	void Start () {
		iphonePlayerCostumeView.SetActive (true);
		iphonePigCostumeView.SetActive (false);
		iphoneSpecialCostumeView.SetActive (false);
		ipadPlayerCostumeView.SetActive (true);
		ipadPigCostumeView.SetActive (false);
		ipadSpecialCostumeView.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		currentPlayerCostumeNumber = PlayerPrefs.GetInt ("PlayerCostume");
		currentPigCostumeNumber = PlayerPrefs.GetInt ("PigCostume");
		currentPigCostume = PigCostumes [PlayerPrefs.GetInt ("PigCostume")];
		currentPlayerCostume = PlayerCostumes [PlayerPrefs.GetInt("PlayerCostume")];

		iphonePlayerCostumeHolder.GetComponent<Image>().sprite = currentPlayerCostume;
		ipadPlayerCostumeHolder.GetComponent<Image> ().sprite = currentPlayerCostume;
		iphonePigCostumeHolder.GetComponent<Image> ().sprite = currentPigCostume;
		ipadPigCostumeHolder.GetComponent<Image> ().sprite = currentPigCostume;
			


	}
	public void Back()
	{
		PlayerPrefs.SetString("NextScene", "TouchScreenMenu");
		SceneManager.LoadScene ("TouchScreenLoadingScreen");
	}
	public void PlayerCostumeScreen()
	{
		iphonePlayerCostumeView.SetActive (true);
		iphonePigCostumeView.SetActive (false);
		iphoneSpecialCostumeView.SetActive (false);
		ipadPlayerCostumeView.SetActive (true);
		ipadPigCostumeView.SetActive (false);
		ipadSpecialCostumeView.SetActive (false);
		iphoneDisplayView.SetActive(true);
		ipadDisplayView.SetActive(true);
	}
	public void PigCostumeView()
	{
		iphonePlayerCostumeView.SetActive (false);
		iphonePigCostumeView.SetActive (true);
		iphoneSpecialCostumeView.SetActive (false);
		ipadPlayerCostumeView.SetActive (false);
		ipadPigCostumeView.SetActive (true);
		ipadSpecialCostumeView.SetActive (false);
		iphoneDisplayView.SetActive(true);
		ipadDisplayView.SetActive(true);
	}
	public void LeagueCostumeView()
	{
		iphonePlayerCostumeView.SetActive (false);
		iphonePigCostumeView.SetActive (false);
		iphoneSpecialCostumeView.SetActive (true);
		ipadPlayerCostumeView.SetActive (false);
		ipadPigCostumeView.SetActive (false);
		ipadSpecialCostumeView.SetActive (true);
		iphoneDisplayView.SetActive(true);
		ipadDisplayView.SetActive(true);
	}
}
