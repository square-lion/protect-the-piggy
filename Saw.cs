using UnityEngine;
using System.Collections;

public class Saw : MonoBehaviour {

	public bool goRight;
	public float moveSpeed;
	public CircleCollider2D circle;

	private int hitpoints = 100;
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

		if (goRight) {
			rb.velocity = new Vector2 (moveSpeed, 0);
		}
		if (!goRight) {
			rb.velocity = new Vector2 (-moveSpeed, 0);
			transform.localScale = new Vector3(-1,1,1);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Zombie")) {
			hitpoints--;
			other.GetComponent<EnemyController> ().TakeDamage (gunDamage);
		}
		if(other.CompareTag ("Box") || other.CompareTag("Player") || other.CompareTag("Bills"))
		{
			 Physics2D.IgnoreCollision(other.GetComponent<BillPickup>().solid, circle);
		}
		if(other.CompareTag("Spawner"))
		{
			Destroy(gameObject);
		}

	}
}
