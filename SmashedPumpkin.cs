using UnityEngine;
using System.Collections;

public class SmashedPumpkin : MonoBehaviour {

	public BoxCollider2D circle;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag ("Box") || other.CompareTag("Player") || other.CompareTag("Bills"))
		{
			 Physics2D.IgnoreCollision(other.GetComponent<Collider2D>(), circle);
		}
	}
}
