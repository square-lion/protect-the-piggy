using UnityEngine;
using System.Collections;

public class BoxController : MonoBehaviour {

	public GameObject Parachute;
	public BoxCollider2D solid;

	private AmmoController am;
	private int AmmoToAdd;
	// Use this for initialization
	void Start () {
		AmmoToAdd = 5 + PlayerPrefs.GetInt ("AddedAmmo");
		am = FindObjectOfType<AmmoController> ();
	}
	
	// Update is called once per frame
	void Update () {
	 
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Grounds") {
			Destroy (Parachute);
		}
		if (other.name == "Player") {
			bool done = false;
			if(!done){
			Debug.Log("Stop");
			done=true;
			AddAmmo ();
			}
		}
		if(other.CompareTag("Zombie"))
		{
			Physics2D.IgnoreCollision(other.GetComponent<EnemyController>().solid, solid);
		}
		if(other.CompareTag("Bills")){
			Physics2D.IgnoreCollision(other.GetComponent<BillPickup>().solid, solid);
		}
	}
	public void AddAmmo()
	{
		am.currentAmmo += AmmoToAdd;
		Destroy (gameObject);
	}
		
}
