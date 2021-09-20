using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

	public GameObject iphoneReviveScreen;
	public GameObject ipadReviveScreen;

	public Camera mainCamera;

	public static bool gameOver;

	public float cameraZoomSpeed;
	// Use this for initialization
	void Start () {
		iphoneReviveScreen.SetActive (false);
		ipadReviveScreen.SetActive (false);

		gameOver = false;
		Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (GameObject.FindGameObjectsWithTag("Pig") == null) {
			GameOver ();
		}
		if(gameOver)
		{
			EnemyController[] zombies = FindObjectsOfType<EnemyController>();
			foreach(EnemyController v in zombies)
				{
					Destroy(v.gameObject);
				}
		}
	}
	public void GameOver()
	{
		iphoneReviveScreen.SetActive (true);
		ipadReviveScreen.SetActive (true);
		gameOver = true;
		//mainCamera.transform.position = new Vector3 (0f, 0f, -10f);
		//mainCamera.GetComponent<Camera> ().orthographicSize -= cameraZoomSpeed *Time.deltaTime;
	}
}
