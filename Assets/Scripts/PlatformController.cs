using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class PlatformController : MonoBehaviour {

	public GameObject iphoneCanvas;
	public GameObject ipadCanvas;
	// Use this for initialization
	void Start () {
		
		 if((Device.generation.ToString()).IndexOf("iPad") > -1){
			iphoneCanvas.SetActive (false);
			ipadCanvas.SetActive (true);
		}

		else {
			iphoneCanvas.SetActive (true);
			ipadCanvas.SetActive (false);
		}

			
	}
}
