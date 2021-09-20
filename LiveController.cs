using UnityEngine;
using System.Collections;

public class LiveController : MonoBehaviour {

	public GameObject[] iphoneLives;
	public GameObject[] ipadLives;
	public GameObject[] iphoneDeadLives;
	public GameObject[] ipadDeadLives;

	public int maxHealth;
	public int health;

	public GameObject player;
	public AudioSource ad;
	// Use this for initialization
	void Start () {

		maxHealth = 5 + PlayerPrefs.GetInt ("AddedHearts");
		health = 5 + PlayerPrefs.GetInt ("AddedStartHearts");

		iphoneDeadLives [0].SetActive (true);
		iphoneDeadLives [1].SetActive (true);
		iphoneDeadLives [2].SetActive (true);
		iphoneDeadLives [3].SetActive (true);
		iphoneDeadLives [4].SetActive (true);

		ipadDeadLives [0].SetActive (true);
		ipadDeadLives [1].SetActive (true);
		ipadDeadLives [2].SetActive (true);
		ipadDeadLives [3].SetActive (true);
		ipadDeadLives [4].SetActive (true);

		if (maxHealth >= 6) {
			iphoneDeadLives [5].SetActive (true);
			ipadDeadLives [5].SetActive (true);
		} else {
			iphoneDeadLives [5].SetActive (false);
			ipadDeadLives [5].SetActive (false);
		}
		if (maxHealth >= 7) {
			iphoneDeadLives [6].SetActive (true);
			ipadDeadLives [6].SetActive (true);
		} else {
			iphoneDeadLives [6].SetActive (false);
			ipadDeadLives [6].SetActive (false);
		}
		if (maxHealth >= 8) {
			iphoneDeadLives [7].SetActive (true);
			ipadDeadLives [7].SetActive (true);
		} else {
			iphoneDeadLives [7].SetActive (false);
			ipadDeadLives [7].SetActive (false);
		}
		if (maxHealth >= 9) {
			iphoneDeadLives [8].SetActive (true);
			ipadDeadLives [8].SetActive (true);
		} else {
			iphoneDeadLives [8].SetActive (false);
			ipadDeadLives [8].SetActive (false);
		}
		if (maxHealth >= 10) {
			iphoneDeadLives [9].SetActive (true);
			ipadDeadLives [9].SetActive (true);
		} else {
			iphoneDeadLives [9].SetActive (false);
			ipadDeadLives [9].SetActive (false);
		}

	}

	
	// Update is called once per frame
	void Update () {
		

		if (health <= 0) {
			player.gameObject.SetActive(false);
			ad.Play ();
			iphoneLives [0].SetActive (false);
			ipadLives [0].SetActive (false);
		}

		if (health >= 1) {
			iphoneLives [0].SetActive (true);
			ipadLives [0].SetActive (true);
		} else {
			iphoneLives [0].SetActive (false);
			ipadLives [0].SetActive (false);
		}

		if (health >= 2) {
			iphoneLives [1].SetActive (true);
			ipadLives [1].SetActive (true);
		} else {
			iphoneLives [1].SetActive (false);
			ipadLives [1].SetActive (false);
		}

		if (health >= 3) {
			iphoneLives [2].SetActive (true);
			ipadLives [2].SetActive (true);
		} else {
			iphoneLives [2].SetActive (false);
			ipadLives [2].SetActive (false);
		}

		if (health >= 4) {
			iphoneLives [3].SetActive (true);
			ipadLives [3].SetActive (true);
		} else {
			iphoneLives [3].SetActive (false);
			ipadLives [3].SetActive (false);
		}

		if (health >= 5) {
			iphoneLives [4].SetActive (true);
			ipadLives [4].SetActive (true);
		} else {
			iphoneLives [4].SetActive (false);
			ipadLives [4].SetActive (false);
		}

		if (health >= 6 && maxHealth >= 6) {
			iphoneLives [5].SetActive (true);
			ipadLives [5].SetActive (true);
		} else {
			iphoneLives [5].SetActive (false);
			ipadLives [5].SetActive (false);
		}

		if (health >= 7 && maxHealth >= 7) {
			iphoneLives [6].SetActive (true);
			ipadLives [6].SetActive (true);
		} else {
			iphoneLives [6].SetActive (false);
			ipadLives [6].SetActive (false);
		}

		if (health >= 8 && maxHealth >= 8) {
			iphoneLives [7].SetActive (true);
			ipadLives [7].SetActive (true);
		} else {
			iphoneLives [7].SetActive (false);
			ipadLives [7].SetActive (false);
		}

		if (health >= 9 && maxHealth >= 9) {
			iphoneLives [8].SetActive (true);
			ipadLives [8].SetActive (true);
		} else {
			iphoneLives [8].SetActive (false);
			ipadLives [8].SetActive (false);
		}

		if (health >= 10 && maxHealth >= 10) {
			iphoneLives [9].SetActive (true);
			ipadLives [9].SetActive (true);
		} else {
			iphoneLives [9].SetActive (false);
			ipadLives [9].SetActive (false);
		}

		if(health > maxHealth)
		health = maxHealth;
	}
	public void TakeDamage (int damage)
	{
		health -= damage;

		player.GetComponent<Rigidbody2D> ().AddForce (new Vector2(50f,0f));
	}


}
