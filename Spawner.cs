using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

	public float spawnNumber;

	public bool leftSide;
	public float ZombieSpawnDelay;
	public float ZombieNoArmDelay;
	public float ZombieDogSpawnDelay;
	public float ZombieGiantSpawnDelay;
	public float ZombieNoLegSpawnDelay;
	public float ZombiePiletSpawnDelay;
	public float ZombieTurtleSpawnDelay;
	public float ZombieSmartSpawnDelay;
	public float ZombieAssasinSpawnDelay;
	public float ZombieRunnerSpawnDelay;
	public float ZombiePigSpawnDelay;
	public float ZombieMetalSpawnDelay;
	public GameObject[] enemies;
	public GameObject skyspawner;
	public GameObject bigSpawner;
	public bool[] spawned;

	public GameObject newZombieText;
	public AudioSource ad;



	// Use this for initialization
	void Start () {
		newZombieText.SetActive (false);

		InvokeRepeating ("SpawnZombie", ZombieSpawnDelay, ZombieSpawnDelay);
		InvokeRepeating ("SpawnNoArmZombie", 0f, ZombieNoArmDelay);
		InvokeRepeating ("SpawnZombieDog", 0f, ZombieDogSpawnDelay);
		InvokeRepeating ("SpawnGiantZombie", 0f, ZombieGiantSpawnDelay);
		InvokeRepeating ("SpawnNoLegZombie", 0f, ZombieNoLegSpawnDelay);
		InvokeRepeating ("SpawnPioletZombie", 0f, ZombiePiletSpawnDelay);
		InvokeRepeating ("SpawnTurtleZombie", 0f, ZombieTurtleSpawnDelay);
		InvokeRepeating ("SpawnSmartZombie", 0f, ZombieSmartSpawnDelay);
		InvokeRepeating ("SpawnAssasinZombie", 0f, ZombieAssasinSpawnDelay);
		InvokeRepeating ("SpawnRunnerZombie", 0f, ZombieRunnerSpawnDelay);
		InvokeRepeating ("SpawnPigZombie", 0f, ZombiePigSpawnDelay);
		InvokeRepeating ("SpawnMetalZombie", 0f, ZombieMetalSpawnDelay);

	}
	public void SpawnZombie()
	{
			Instantiate (enemies[0], transform.position, transform.rotation);
			spawnNumber++;
	}
	public void SpawnNoArmZombie()
	{
		if (!spawned[0] && spawnNumber >= 10) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				spawned[0] = true;
			}
		}
		if(spawnNumber >= 10)	
		Instantiate (enemies[1], transform.position, transform.rotation);


	}
	public void SpawnZombieDog()
	{
		if (!spawned[1]&& spawnNumber >= 20) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				ad.Play ();
				spawned[1] = true;
		
			}
		}
			if(spawnNumber >= 20)
			Instantiate (enemies[2], transform.position, transform.rotation);
		}


	public void SpawnGiantZombie()
	{
		if (!spawned[2]&& spawnNumber >= 30) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				spawned[2] = true;
			}
		}
		if(spawnNumber >= 30)	
			Instantiate (enemies[3], bigSpawner.transform.position, transform.rotation);


	}
	public void SpawnNoLegZombie()
	{
		if (!spawned[3]&& spawnNumber >= 40) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				spawned[3] = true;
			}
		}
		if(spawnNumber >= 40)	
			Instantiate (enemies[4], transform.position, transform.rotation);


	}
	public void SpawnPioletZombie()
	{
		 if (!spawned[4]&& spawnNumber >= 50) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				spawned[4] = true;
			}
		}
		if(spawnNumber >= 50)	
			Instantiate (enemies[5], skyspawner.transform.position, transform.rotation);


	}
	public void SpawnTurtleZombie()
	{
		if (!spawned[5]&& spawnNumber >= 60) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				spawned[5] = true;
			}
		}
		if(spawnNumber >= 60)	
			Instantiate (enemies[6], bigSpawner.transform.position, transform.rotation);

	}
	public void SpawnSmartZombie()
	{
		if (!spawned[6]&& spawnNumber >= 70) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				spawned[6] = true;
			}
		}
		if(spawnNumber >= 70)	
			Instantiate (enemies[7], transform.position, transform.rotation);

	}
	public void SpawnAssasinZombie()
	{
		if (!spawned[7]&& spawnNumber >= 80) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				spawned[7] = true;
			}
		}
		if(spawnNumber >= 80)	
			Instantiate (enemies[8], transform.position, transform.rotation);

	}
	public void SpawnRunnerZombie()
	{
		if (!spawned[8]&& spawnNumber >= 90) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				spawned[8] = true;
			}
		}
		if(spawnNumber >= 90)	
			Instantiate (enemies[9], transform.position, transform.rotation);

	}
	public void SpawnPigZombie()
	{
		if (!spawned[9]&& spawnNumber >= 100) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				spawned[9] = true;
			}
		}
		if(spawnNumber >= 100)	
			Instantiate (enemies[10], transform.position, transform.rotation);

	}
	public void SpawnMetalZombie()
	{
		if (!spawned[10]&& spawnNumber >= 110) {
			if (leftSide) {
				newZombieText.SetActive (true);
				newZombieText.GetComponent<Text> ().text = "New Zombie Incoming!";
				spawned[10] = true;
			}
		}
		if(spawnNumber >= 110)	
			Instantiate (enemies[11], bigSpawner.transform.position, transform.rotation);

	}
}
