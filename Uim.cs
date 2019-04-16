using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Uim : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{

	}
		
	// Update is called once per frame
	void Update () {
	
	}
	public void Play(){



		if (Time.timeScale == 0) {
			Time.timeScale = 1f;
		}
		PlayerPrefs.SetInt ("Shielder", 0);
		PlayerPrefs.SetInt ("CurrentMoney1", 0);
		SceneManager.LoadScene("Level");
	}

	public void Shop(){
		
	}

	public void Options(){
		
	}

	public void Leaderboard(){
		
	}
	public void Rank(){
		
	}


}
