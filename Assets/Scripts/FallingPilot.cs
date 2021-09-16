using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPilot : MonoBehaviour {

	public GameObject PilotZombie;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Ground"))
		{
			Instantiate(PilotZombie, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
}
