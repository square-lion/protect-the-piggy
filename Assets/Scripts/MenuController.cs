using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {


	public string settings;
	public string play;
	public string shop;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Settings()
	{
		SceneManager.LoadScene (settings);
	}
	public void Play()
	{
		SceneManager.LoadScene (play);
	}
	public void Shop()
	{
		SceneManager.LoadScene (shop);
	}
	public void Exit()
	{
		Application.Quit ();
	}
}
