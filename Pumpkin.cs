using UnityEngine;
using System.Collections;

public class Pumpkin : MonoBehaviour {

	public bool goRight;
	public float moveSpeed;
	public float upHieght;
	public GameObject splatter;

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
		
		if(goRight)
		rb.velocity = new Vector2 (moveSpeed,upHieght);
		if(!goRight)
		rb.velocity = new Vector2 (-moveSpeed,upHieght);

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Zombie")) {
			Destroy(gameObject);
			other.GetComponent<EnemyController> ().TakeDamage (gunDamage);
		}
		if(other.CompareTag("Ground"))
		{
			Destroy(gameObject);
			Instantiate(splatter, transform.position, splatter.transform.rotation);
		}

	}
}
