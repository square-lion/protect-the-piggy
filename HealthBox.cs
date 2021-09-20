using UnityEngine;
using System.Collections;

public class HealthBox : MonoBehaviour {

	public GameObject parachute;
	public BoxCollider2D solid;
	private LiveController lives;
	private int HealthToAdd;
	// Use this for initialization
	void Start () {
		HealthToAdd = 1 + PlayerPrefs.GetInt ("AddedHealth");

		lives = FindObjectOfType<LiveController> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag ("Box"))
			{
				Physics2D.IgnoreCollision (GetComponent<Collider2D> (), other.GetComponent<Collider2D> ());
			}

		if(other.CompareTag ("Zombie"))
			{
			Physics2D.IgnoreCollision (other.GetComponent<EnemyController>().solid, solid);
			}

		if (other.name == "Grounds") {
			Destroy (parachute);
		}
		if (other.name == "Player") {
			bool done = false;
			if(!done){
			lives.health = lives.health + HealthToAdd;
			Destroy (gameObject);
			done = true;
			}
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
