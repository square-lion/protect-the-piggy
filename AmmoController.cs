using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AmmoController : MonoBehaviour {

	public Text iphoneAmmoText;
	public Text ipadAmmoText;

	public int currentAmmo = 0;
	public GameObject iphoneBullet;
	public GameObject ipadBullet;
	public GameObject currentgun;
	public GameObject currentknife;
	public GameObject iphoneGunButton;
	public GameObject iphoneKnifeButton;
	public GameObject ipadGunButton;
	public GameObject ipadKnifeButton;
	private PlayerController player;
	private bool start;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController>();
		currentknife = player.currentKnife;
		currentgun = player.currentGun;
		currentgun.SetActive(false);
		currentknife.SetActive(true);

		ipadBullet.SetActive (false);
		iphoneBullet.SetActive (false);
		iphoneGunButton.SetActive (false);
		ipadGunButton.SetActive (false);
		iphoneKnifeButton.SetActive (true);
		ipadKnifeButton.SetActive (true);
		iphoneAmmoText.text = "";
		ipadAmmoText.text = "";
		start = true;

	}

	// Update is called once per frame
	void FixedUpdate () {
		if (currentAmmo == 0 && !start) {
			//gun.GetComponent<AudioSource> ().Play ();
			StartCoroutine("noAmmo");

		}

		if(currentAmmo > 0)
		{
			StopCoroutine("noAmmo");
			currentknife.SetActive (false);
			currentgun.SetActive(true);
			iphoneBullet.SetActive (true);
			ipadBullet.SetActive (true);
			iphoneAmmoText.text = "" + currentAmmo;
			ipadAmmoText.text = "" + currentAmmo;
			iphoneGunButton.SetActive (true);
			ipadGunButton.SetActive (true);
			iphoneKnifeButton.SetActive (false);
			ipadKnifeButton.SetActive (false);
			start = false;
		}
		
	}
	public void TakeAmmo(int ammo)
	{
		currentAmmo -= ammo;
	}
	public IEnumerator noAmmo()
	{
		yield return new WaitForSeconds (currentgun.GetComponent<GunController>().shootDelay);
		ipadBullet.SetActive (false);
		iphoneBullet.SetActive (false);
		currentgun.SetActive (false);
		iphoneGunButton.SetActive (false);
		ipadGunButton.SetActive (false);
		currentknife.SetActive (true);
		iphoneKnifeButton.SetActive (true);
		ipadKnifeButton.SetActive (true);
		iphoneAmmoText.text = "";
		ipadAmmoText.text = "";

	}
}
