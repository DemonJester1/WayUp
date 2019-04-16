using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class UiManager : MonoBehaviour {

	public bool gameOver;
	public Text scoreText;
	public int score;
	public float timeCounter;
	public float acc1 = 0.00005f;
	public float timescale = 0.5f;
	public bool scoreUp;
	public int highscore;
	public Text highscorer;
	public Button[] buttons;
	bool advertismentWatched;
	bool advertismentNotWatched;
	int duck;
	public bool notClicked;
	public float timer = 5f;
	public Text timerText;

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetInt ("hiscore", 0);

		Advertisement.Initialize ("1332114");

		notClicked = false;
		advertismentNotWatched = false;
		advertismentWatched = false;
		gameOver = false;
		scoreUp = false;

		InvokeRepeating ("scoreUpdate", 8f, 2f);

		score = PlayerPrefs.GetInt ("Shielder");

		scoreText.text = "" + score;

		if (PlayerPrefs.HasKey ("duck")) {
			duck = PlayerPrefs.GetInt ("duck");
		} else {
			duck = 0;
			PlayerPrefs.SetInt ("duck", 0);
		}

		if (PlayerPrefs.HasKey ("hiscore")) {
			highscore = PlayerPrefs.GetInt ("hiscore");
		} else {
			highscore = 0;
			PlayerPrefs.SetInt ("hiscore", 0);
		}
		highscorer.text = "" + highscore;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.timeScale == 1f) {
			acc1 = 0.00005f;
		}

		if (highscore < score) {
			PlayerPrefs.SetInt ("hiscore", score);
		}

		if (notClicked == true) {
			timer -= Time.unscaledDeltaTime;
			timerText.text = "" + Mathf.RoundToInt(timer);
			if (timer <= 0) {
				timer = 0;
				duck = 1;
				gameOverActivated ();
			}
		}
	}
		
	void FixedUpdate () {
		timeCounter += Time.fixedDeltaTime;
		if (timeCounter > 0) {
			Time.timeScale += acc1;
		}
	}

	void scoreUpdate(){
		if (gameOver == false) {
			score += 1;
			PlayerPrefs.SetInt ("Shielder", score);
			scoreText.text = "" + score;
		}
		if (scoreUp == true && gameOver == false) {
			score += 1;
			PlayerPrefs.SetInt ("Shielder", score);
			scoreText.text = "" + score;
		}
	}

	public void gameOverActivated(){
		if ((score + 10) >= highscore && duck == 0) {
			notClicked = true;
			Time.timeScale = 0;
			transform.GetChild (0).gameObject.SetActive (true);
			if ( advertismentWatched == true) {
				duck = 1;
				PlayerPrefs.SetInt ("duck", 1);
				SceneManager.LoadScene ("Level");
				Time.timeScale = 1f;
				advertismentWatched = false;
			} else if(advertismentNotWatched == true){
				SceneManager.LoadScene ("submenu");
				advertismentNotWatched = false;
			}
		} else if ((score + 10) < highscore || duck == 1) {
			score = PlayerPrefs.GetInt ("Shielder");
			gameOver = true;
			duck = 0;
			PlayerPrefs.SetInt ("duck", 0);
			Time.timeScale = 0;
			scoreText.text = "" + score;
			SceneManager.LoadScene ("submenu");
		}
	}

	public void Paly(){

		if (Time.timeScale == 0) {
			Time.timeScale = 1f;
			PlayerPrefs.SetInt ("Shielder", 0);
			PlayerPrefs.SetInt ("CurrentMoney1", 0);
		}

		SceneManager.LoadScene ("Level");
	}

	public void Exit(){
		Application.Quit();
	}

	public void Submenu(){
		if (Time.timeScale == 0) {
			Time.timeScale = 1f;
		}
		SceneManager.LoadScene ("submenu");
	}

	public void Pause(){
		if (Time.timeScale > timescale) {
			acc1 = 0;
			Time.timeScale = 0;
			foreach (Button button in buttons) {
				button.gameObject.SetActive (true);
			}
		}
	}
	public void Unpause(){
		if (Time.timeScale == 0 && gameOver == true) {
			PlayerPrefs.SetInt ("Shielder", 0);
			PlayerPrefs.SetInt ("CurrentMoney1", 0);
		}
		if (Time.timeScale == 0) {
			acc1 = 0.00005f;
			Time.timeScale = 1 + (acc1 * 50 * timeCounter);
			foreach (Button button in buttons) {
				button.gameObject.SetActive (false);
			}
		}
	}

	public void ShowRewardedAd(){

		notClicked = false;

		if (Advertisement.IsReady ("rewardedVideo")) {
			var options = new ShowOptions{ resultCallback = HandleShowResult };
			Advertisement.Show ("rewardedVideo", options);
		}
	}

	public void HandleShowResult(ShowResult result){
		switch (result) {
		case ShowResult.Finished:
			advertismentWatched = true;
			gameOverActivated ();
			break;
		case ShowResult.Skipped:
			advertismentNotWatched = false;
			break;
		case ShowResult.Failed:
			advertismentNotWatched = false;
			break;
		}
	}
	public void Home(){
		SceneManager.LoadScene ("submenu");
	}


		
}
