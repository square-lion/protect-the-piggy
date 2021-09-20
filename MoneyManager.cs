using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour {

	public int money;
	// Use this for initialization
	void Start () {
		money = PlayerPrefs.GetInt ("Coins");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AddMoney(int score)
	{
		Debug.Log('d');
		money += score;
		PlayerPrefs.SetInt ("Coins", money);
	}
}
