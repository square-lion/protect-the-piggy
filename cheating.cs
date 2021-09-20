using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheating : MonoBehaviour {

	public void Clicked()
	{
		int coins = PlayerPrefs.GetInt("Coins");
		coins += 40000;
		PlayerPrefs.SetInt("Coins", coins);
	}
}
