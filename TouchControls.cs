using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour {

	public GameObject currentKnife;
	public GameObject[] knifes;

	public GameObject currentGun;
	public GameObject[] guns;

	public PlayerController player;

	public AudioSource walking;


	void Start()
	{
		currentKnife = player.currentKnife;
		currentGun = player.currentGun;
	}

	public void WalkLeft()
	{
		player.MoveLeft (player.moveSpeed);
		walking.Play ();
	}
	public void WalkRight()
	{
		player.MoveRight (player.moveSpeed);
		walking.Play ();
	}
	public void SwingKnife()
	{
		currentKnife.GetComponent<knifeController> ().Knife();
		//currentKnife.GetComponent<Animator> ().SetBool ("Swinging", true);
	}
	public void ShootGun()
	{
		currentGun.GetComponent<GunController> ().Gun ();
	}
	public void UnPressedLeft()
	{
		player.MoveLeft (0);
		player.GetComponent<Animator>().SetBool ("Is Walking", false);
		walking.Stop ();
	}
	public void UnPressedRight()
	{
		player.MoveRight (0);
		player.GetComponent<Animator>().SetBool ("Is Walking", false);
		walking.Stop ();
	}
		
}
