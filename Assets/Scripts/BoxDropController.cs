using UnityEngine;
using System.Collections;

public class BoxDropController : MonoBehaviour {

	public GameObject box;
	public GameObject healthBox;
	public GameObject[] dropSpots;
	public GameObject healthDropSpot;
	public float dropDelay;
	public float healthDropDelay;
	// Use this for initialization
	void Start () {
		dropDelay = dropDelay - PlayerPrefs.GetInt ("subtractedTimeA") / 2;
		healthDropDelay = healthDropDelay - PlayerPrefs.GetInt ("subtractedTimeH") / 2;

		InvokeRepeating ("DropBox", dropDelay, dropDelay);
		InvokeRepeating ("HealthDropBox", healthDropDelay, healthDropDelay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void DropBox()
	{
		int spawnpointIndex = Random.Range (0, dropSpots.Length);

		Instantiate (box, dropSpots [spawnpointIndex].transform.position, dropSpots [spawnpointIndex].transform.rotation);
	}
	public void HealthDropBox()
	{
		Instantiate (healthBox, healthDropSpot.transform.position, healthDropSpot.transform.rotation);
	}
}
