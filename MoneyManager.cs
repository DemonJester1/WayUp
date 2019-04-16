using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

	public Text moneyText;
	public int currentGold;
	public int currentGold1;
	public Text moneyyText;

	// Use this for initialization
	void Start () {

		moneyText = GameObject.Find("Money").GetComponent<Text>();
		moneyyText = GameObject.Find ("Moneyy").GetComponent<Text> (); 
			
		if (PlayerPrefs.HasKey ("CurrentMoney")) {
			currentGold = PlayerPrefs.GetInt ("CurrentMoney");
		} else {
			currentGold = 0;
			PlayerPrefs.SetInt ("CurrentMoney", 0);
		}

		if (PlayerPrefs.HasKey ("CurrentMoney1")) {
			currentGold1 = PlayerPrefs.GetInt ("CurrentMoney1");
		} else {
			currentGold1 = 0;
			PlayerPrefs.SetInt ("CurrentMoney1", 0);
		}


		moneyyText.text = "" + currentGold1;

		moneyText.text = "" + currentGold;
	}

	public void AddMoney(int goldToAdd){
		currentGold += goldToAdd;
		currentGold1 += goldToAdd;
		PlayerPrefs.SetInt ("CurrentMoney", currentGold);
		PlayerPrefs.SetInt ("CurrentMoney1", currentGold1);
		moneyyText.text = "" + currentGold1;
	}

	// Update is called once per frame
	void Update () {
	}

}

