using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBullet : MonoBehaviour {

	public int Damage;
	public GunController gun;
	public AudioSource ad;
	// Use this for initialization
	void Start () {
		if(gun == null)
			return;
		else
		Damage = gun.damage;

	}
	// Update is called once per frame
	void Update () {
		if (ad.isPlaying) {
			return;
		}else	
		ad.Play ();
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Zombie"))
			{
			other.GetComponent<EnemyController> ().TakeDamage (Damage);
			}
	}
}
