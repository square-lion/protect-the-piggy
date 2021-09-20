using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UpgradeMenuController : MonoBehaviour {

	public GameObject heartView;
	public GameObject ammoView;
	public GameObject healthView;
	public GameObject ipadHeartView;
	public GameObject ipadAmmoView;
	public GameObject ipadHealthView;

	public Text coinText;
	public Text billText;
	public Text ipadCoinsText;
	public Text ipadBillText;
	// Use this for initialization
	void Start () {

		heartView.SetActive (true);
		ammoView.SetActive (false);
		healthView.SetActive (false);
		ipadHealthView.SetActive (false);
		ipadAmmoView.SetActive (false);
		ipadHeartView.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		coinText.text = "" + PlayerPrefs.GetInt ("Coins");
		ipadCoinsText.text = "" + PlayerPrefs.GetInt ("Coins");
		billText.text = "" +PlayerPrefs.GetInt ("Bills");
		ipadBillText.text = "" + PlayerPrefs.GetInt ("Bills");
	}
	public void goToHeartView()
	{
		heartView.SetActive (true);
		ammoView.SetActive (false);
		healthView.SetActive (false);
		ipadHealthView.SetActive (false);
		ipadAmmoView.SetActive (false);
		ipadHeartView.SetActive (true);
	}
	public void goToAmmoView()
	{
		heartView.SetActive (false);
		ammoView.SetActive (true);
		healthView.SetActive (false);
		ipadHealthView.SetActive (false);
		ipadAmmoView.SetActive (true);
		ipadHeartView.SetActive (false);
	}
	public void goToHealthView()
	{
		Debug.Log ("adsf");
		heartView.SetActive (false);
		ammoView.SetActive (false);
		healthView.SetActive (true);
		ipadHealthView.SetActive (true);
		ipadAmmoView.SetActive (false);
		ipadHeartView.SetActive (false);
	}
	public void Back()
	{
		PlayerPrefs.SetString("NextScene", "TouchScreenMenu");
		SceneManager.LoadScene ("TouchScreenLoadingScreen");
	}
}
