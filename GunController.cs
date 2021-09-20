using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

	public int GunID;
	public int damage;
	public GameObject bullet;
	public GameObject gunPoint;
	public float shootDelay;
	private float currentDelay;

	 [Space(5)]
	public bool rapidFire;

	 [Space(5)]
	 [Header("Special Bullet")]
	public bool hasSpecialBullet;
	public GameObject specialBullet;

	 [Space(5)]
	 [Header("Interchangable Bullet")]
	public bool IsInterchangable;
	public GameObject[] bullets;
	public Sprite[] guns;
	private int round;

	private AmmoController am;
	private SpriteRenderer sp;
	private AudioSource ad;

	private bool gameStart;
	// Use this for initialization
	void Awake () {
			if (hasSpecialBullet) 
			specialBullet.SetActive (false);
		
			gameObject.SetActive (false);

		sp = GetComponent<SpriteRenderer> ();
		am = FindObjectOfType<AmmoController> ();
		ad = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		currentDelay -= Time.deltaTime;

		if (hasSpecialBullet) {
			if (currentDelay >= 0 && hasSpecialBullet) {
				specialBullet.SetActive (true);
			} else
				specialBullet.SetActive (false);
		}
		if(IsInterchangable)
		{
			sp.sprite = guns[round];
		}
	}
	public void Shoot()
	{
		if (rapidFire)
			StartCoroutine ("RapidFire");
		else if (hasSpecialBullet)
			SpecialBulletActive ();
		else if (IsInterchangable)
			InterchangableShot();
		else {
			Instantiate (bullet, gunPoint.transform.position, bullet.transform.rotation);
			ad.Play ();
		}
		
			
	}
	public IEnumerator RapidFire()
	{
		ad.Play ();
		Instantiate (bullet, gunPoint.transform.position, transform.rotation);
		yield return new WaitForSeconds (.2f);
		ad.Play ();
		Instantiate (bullet, gunPoint.transform.position, transform.rotation);
		yield return new WaitForSeconds (.2f);
		ad.Play ();
		Instantiate (bullet, gunPoint.transform.position, transform.rotation);
		yield return new WaitForSeconds (.2f);

	}

	public void Gun()
	{
		if (currentDelay <= 0) {
			am.TakeAmmo (1);
			currentDelay = shootDelay;

			Shoot ();
		}		
	}
	public void SpecialBulletActive()
	{
		if (currentDelay <= 0) {
			specialBullet.SetActive (true);	
			currentDelay = shootDelay;
		}
	}
	public void InterchangableShot()
	{
		Instantiate(bullets[round], gunPoint.transform.position, transform.rotation);	
		round++;	
		if(round == guns.Length)
			round = 0;
		
		
	}

}
