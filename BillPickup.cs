using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillPickup : MonoBehaviour {

	public BoxCollider2D solid;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
			bool done = false;
			if(!done){
			done = true;
			int bills = PlayerPrefs.GetInt("Bills");
			bills++;
			PlayerPrefs.SetInt("Bills", bills);
			Destroy(gameObject);
			}
		}
		if(other.CompareTag("Zombie"))
		{
			Physics2D.IgnoreCollision(other.GetComponent<EnemyController>().solid, solid);
		}
		if(other.CompareTag("Bills"))
		{
			Physics2D.IgnoreCollision(other.GetComponent<BillPickup>().solid, solid);
		}
	}
}
