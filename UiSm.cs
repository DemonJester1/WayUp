using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiSm : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play(){
		if (Time.timeScale == 0) {
			Time.timeScale = 1f;
			PlayerPrefs.SetInt ("Shielder", 0);
			PlayerPrefs.SetInt ("CurrentMoney1", 0);
		}
		SceneManager.LoadScene("level");
	}

	public void Home(){
		SceneManager.LoadScene ("Menu");
	}

}
