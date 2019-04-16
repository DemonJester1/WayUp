using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {

	public int shields;
	public int doubleScore;
	public Text shieldCount;
	public Text scoreCount;
	public float timeCounter;
	public UiManager ui;
	public Ball B;

	// Use this for initialization
	void Start () {

		B = FindObjectOfType<Ball> ();
		ui = FindObjectOfType<UiManager> ();

		timeCounter = 30f;

		if (PlayerPrefs.HasKey ("Shields")) {
			shields = PlayerPrefs.GetInt ("Shields");
		} else {
			shields = 0;
			PlayerPrefs.SetInt ("Shields", 0);
		}

		if (PlayerPrefs.HasKey ("dScore")) {
			doubleScore = PlayerPrefs.GetInt ("dScore");
		} else {
			doubleScore = 0;
			PlayerPrefs.SetInt ("dScore", 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (ui.scoreUp == true) {
			scoreCount.transform.gameObject.SetActive (true);
			timeCounter -= Time.unscaledDeltaTime;
			scoreCount.text = "" + Mathf.RoundToInt (timeCounter);
			if (timeCounter <= 0f) {
				ui.scoreUp = false;
				scoreCount.transform.gameObject.SetActive (false);
				timeCounter = 30f;
			}
		}

		if (B.shielding == true) {
			timeCounter -= Time.unscaledDeltaTime;
			shieldCount.transform.gameObject.SetActive (true);
			shieldCount.text = "" + Mathf.RoundToInt (timeCounter);
			if (timeCounter <= 0f) {
				B.shielding = false;
				shieldCount.transform.gameObject.SetActive (false);
				timeCounter = 30f;
			}
		}

	}
	public void ShieldEnable(){
		if (shields > 0) {
			shields -= 1;
			PlayerPrefs.SetInt ("Shields", shields);
			B.shielding = true;
		}
	}
	public void ScoreBoost(){
		if (doubleScore > 0) {
			doubleScore -= 1;
			PlayerPrefs.SetInt("dScore",doubleScore);
			ui.scoreUp = true;
		}
	}
}
