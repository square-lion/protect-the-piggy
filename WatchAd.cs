using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class WatchAd : MonoBehaviour {

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
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 25);

    }else if(result == ShowResult.Skipped) {
        Debug.LogWarning("Video was skipped - Do NOT reward the player");

    }else if(result == ShowResult.Failed) {
        Debug.LogError("Video failed to show");
    }
}
}