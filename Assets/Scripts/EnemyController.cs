using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float moveSpeed;
	public int damage;
	public float health;
	public int pointsOnDeath;
	public bool ableToHitPlayer;
	public bool smart;
	public BoxCollider2D solid;
	public GameObject bill;
	private bool goRight;
	private float attackDelay = .1f;
	private bool hitPlayer;
	private float currentDelay;
	private bool canHitPlayer;
	private bool hit;

	private Rigidbody2D rb;
	private PlayerController theplayer;
	private LiveController player;
	private PigController pc;
	private ScoreController sc;

	private int kills;
		// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		theplayer = FindObjectOfType<PlayerController> ();
		pc = FindObjectOfType<PigController> ();
		player = FindObjectOfType<LiveController> ();
		sc = FindObjectOfType<ScoreController> ();
	}


	// Update is called once per frame
	void Update () {

		if (health <= 0) {
			int chance = Random.Range(0,4);
			if(chance == 2){
			Instantiate(bill,transform.position, transform.rotation);
			}
			Destroy (gameObject);
			sc.AddToScore (pointsOnDeath);
		}
		if (goRight) {
			rb.velocity = new Vector2 (moveSpeed, 0);
			transform.localScale = new Vector3 (1, 1, 0);
		}
		if (!goRight) {
			rb.velocity = new Vector2 (-moveSpeed, 0);
			transform.localScale = new Vector3 (-1, 1, 0);
		}

		if (!canHitPlayer && !hitPlayer) {
			canHitPlayer = true;
		}
		if (hitPlayer) {
		
			hitPlayer = false;
			currentDelay = attackDelay;
		}
		if (currentDelay > 0) {
			currentDelay -= Time.deltaTime;
			canHitPlayer = false;
		}
		if (currentDelay <= 0) {
			canHitPlayer = true;
			currentDelay = 0;
		}

	}
	void LateUpdate()
	{
		hit = false;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Spawner 1") {
			goRight = true;
		}
		if (other.name == "Spawner 2") {
			goRight =false;
		}
		if(other.CompareTag("Pig"))
			{
			pc.TakeHealth ();
			Destroy (gameObject);
			FindObjectOfType<LevelController> ().GameOver();
			}
		if (other.CompareTag ("Player")) {
			if (!hitPlayer && canHitPlayer && ableToHitPlayer) {
				hitPlayer = true;
				theplayer.knockBackCound = theplayer.knockBackLength;
				//knockBackCound = knockBackLength;
				player.TakeDamage (damage);
			}
			}
		if (other.CompareTag ("Zombie")) {
				Physics2D.IgnoreCollision (solid, other.GetComponent<EnemyController>().solid);
			}
		if(other.CompareTag("SmashedPumpkin"))
			{
				if(!hit){
				hit = true;
				Destroy(other.gameObject);
				TakeDamage(1);
				}
			}
		if(other.CompareTag("Box") && smart)
		{
			
				if(goRight)
					goRight = false;
				else
					goRight = true;
				Destroy(other.gameObject);
			
			
		}
		
	}
	public void TakeDamage(int damage)
	{
		health -= damage;
	}

}
