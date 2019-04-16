using UnityEngine;
using UnityEngine.Advertisements;

public class RequestAd : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Advertisement.Initialize ("1332114");

	}

    // Update is called once per frame
    void Update()
    {

    }
	public void ShowRewardedAd(){

		if (Advertisement.IsReady ("rewardedVideo")) {
			var options = new ShowOptions{ resultCallback = HandleShowResult };
			Advertisement.Show ("rewardedVideo", options);
		}
	}

	public void HandleShowResult(ShowResult result){
		switch (result) {
		case ShowResult.Finished:
			break;
		case ShowResult.Skipped:
			break;
		case ShowResult.Failed:
			break;
		}
	}
}
