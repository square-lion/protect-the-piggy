using UnityEngine;
using System.Collections;

public class knifeController : MonoBehaviour {
	public int KnifeID;
	public int damage;
	public float swingingDelay;
	private float currentDelay;
	private bool hit;

	private Animator anim;
	private AudioSource ad;

	void Start()
	{
		anim = GetComponent<Animator> ();
		ad = GetComponent<AudioSource> ();
	}
	void FixedUpdate()
	{
		currentDelay -= Time.deltaTime;
	}
	void LateUpdate()
	{
		hit = false;
		anim.SetBool ("Swinging", false);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Zombie") && !hit) {
			other.GetComponent<EnemyController> ().TakeDamage (damage);
			hit = true;
		}
	}
	public void Knife()
	{
		if (currentDelay <= 0){
			anim.SetBool ("Swinging", true);
			ad.Play ();
			currentDelay = swingingDelay;
		}
	}
}