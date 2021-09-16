using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ReviveAD : MonoBehaviour {

	private ReviveMenu rev;
    public PlayerController player;

	void Awake()
{
      Advertisement.Initialize ("1608700", true);
      
}
public void ShowRewardedVideo ()
{
    ShowOptions options = new ShowOptions();
    options.resultCallback = HandleShowResult;

    Advertisement.Show("rewardedVideo", options);
}

void HandleShowResult (ShowResult result)
{
    if(result == ShowResult.Finished) {
        rev = gameObject.transform.parent.transform.parent.gameObject.GetComponent<ReviveMenu>();
	    rev.ViewAd();
    	LevelController.gameOver = false;
		FindObjectOfType<PigController>().GetComponent<SpriteRenderer>().enabled = true;
		FindObjectOfType<PigController>().Health = 1;
		PigController.died = false;
        player.gameObject.SetActive(true);
        player.transform.position = new Vector3 (0,.6f,0);
        FindObjectOfType<LiveController>().health = 5;


    }else if(result == ShowResult.Skipped) {
        Debug.LogWarning("Video was skipped - Do NOT reward the player");

    }else if(result == ShowResult.Failed) {
        Debug.LogError("Video failed to show");
    }
}
}
