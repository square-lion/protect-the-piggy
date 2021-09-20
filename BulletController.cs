using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public bool goRight;
	public float moveSpeed;

	[Space(5)]
	public bool hasExplosion;
	public GameObject Explosion;

	[Space(5)]
	public int hitpoints;

	private Rigidbody2D rb;

	private int gunDamage;

	private Vector3 playerScale;
	// Use this for initialization
	void Start () {
		gunDamage = FindObjectOfType<GunController> ().damage;
		rb = GetComponent<Rigidbody2D> ();

		playerScale = FindObjectOfType<PlayerController> ().transform.localScale;

		if (playerScale == new Vector3 (1, 1, 1))
			goRight = true;
		else
			goRight = false;

	}
	
	// Update is called once per frame
	void Update () {
		if(hitpoints <= 0)
		{
			if(hasExplosion)
			Instantiate(Explosion, transform.position, transform.rotation);
			Destroy(gameObject);
		}

		if (goRight) {
			rb.velocity = new Vector2 (moveSpeed, 0);
		}
		if (!goRight) {
			rb.velocity = new Vector2 (-moveSpeed, 0);
			transform.localScale = new Vector3(-transform.localScale.x,transform.localScale.y,1);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Zombie")) {
			hitpoints--;
			other.GetComponent<EnemyController> ().TakeDamage (gunDamage);
		}

	}
}
