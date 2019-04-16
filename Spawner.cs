using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	private float delayTimer;
	float timer;
	public GameObject[] Death;
	public int DeathNo;
	private Vector3 newPosition;

	private float delayTimer1;
	float timer1;
	public GameObject[] Death1;
	int DeathNo1;
	private Vector3 newPosition1;

	public GameObject[] Death2;
	int DeathNo2;
	private Vector3 newPosition2;

	public GameObject Planer;

	// Use this for initialization
	void Awake(){
		delayTimer = 2f;
		delayTimer1 = 2f;
	}

	void Start () {
		timer = delayTimer;

		timer1 = delayTimer1;

		transform.position = newPosition;

		transform.position = newPosition1;

		transform.position = newPosition2;

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 Position0 = new Vector3 (4.5f, 0.5f, 100f);
		Vector3 Position1 = new Vector3 (4f, 0.5f, 100f);
		Vector3 Position2 = new Vector3 (4f, 0.5f, 100f);
		Vector3 Position3 = new Vector3 (4f, 0.5f, 100f);
		Vector3 Position4 = new Vector3 (3.5f, 0.5f, 100f);
		Vector3 Position5 = new Vector3 (3.5f, 0.5f, 100f);
		Vector3 Position6 = new Vector3 (3.5f, 0.5f, 100f);
		Vector3 Position7 = new Vector3 (3.5f, 0f, 100f);
		Vector3 Position8 = new Vector3 (4.5f, 0.5f, 100f);
		Vector3 Position9 = new Vector3 (5.5f, 0.5f, 100f);
		Vector3 Position10 = new Vector3 (5.5f, 0.7f, 100f);
		Vector3 Position11 = new Vector3 (4.5f, 3.5f, 100f);
		Vector3 Position12 = new Vector3 (3.5f, 0.5f, 100f);
		Vector3 Position13 = new Vector3 (3.75f, 0.5f, 100f);

		Vector3 Position0l = new Vector3 (-4.5f, 0.5f, 100f);
		Vector3 Position1l = new Vector3 (-4f, 0.5f, 100f);
		Vector3 Position2l = new Vector3 (-4f, 0.5f, 100f);
		Vector3 Position3l = new Vector3 (-4f, 0.5f, 100f);
		Vector3 Position4l = new Vector3 (-3.5f, 0.5f, 100f);
		Vector3 Position5l = new Vector3 (-3.5f, 0.5f, 100f);
		Vector3 Position6l = new Vector3 (-3.5f, 0.5f, 100f);
		Vector3 Position7l = new Vector3 (-3.5f, 0f, 100f);
		Vector3 Position8l = new Vector3 (-4.5f, 0.5f, 100f);
		Vector3 Position9l = new Vector3 (-5.5f, 0.5f, 100f);
		Vector3 Position10l = new Vector3 (-5.5f, 0.7f, 100f);
		Vector3 Position11l = new Vector3 (-4.5f, 3.5f, 100f);
		Vector3 Position12l = new Vector3 (-3.5f, 0.5f, 100f);
		Vector3 Position13l = new Vector3 (-3.75f, 0.5f, 100f);

		Vector3 Position0m = new Vector3 (1.5f, 0.5f, 100f);
		Vector3 Position1m = new Vector3 (-1.5f, 0.5f, 100f);

		timer -= Time.deltaTime;

		if (DeathNo <= -1) {
			timer1 = delayTimer1;
		} else {
			timer1 -= Time.deltaTime;
		}

		if (timer <= 0) {
			if (DeathNo <= -1) {
				Instantiate (Death2 [DeathNo2], newPosition2, transform.rotation);
				DeathNo2 = Random.Range (0, 2);
			} else {
				Instantiate (Death [DeathNo], newPosition, transform.rotation);
			}
			DeathNo = Random.Range(-4,14);
			timer = delayTimer;
		}
			
		if (timer1 <= 0) {
			Instantiate (Death1 [DeathNo1], newPosition1, transform.rotation);
			DeathNo1 = Random.Range(0,14);
			timer1 = delayTimer1;
			if (DeathNo1 == DeathNo) {
				if (DeathNo1 == 0) {
					DeathNo1 += 1;
				} else {
					DeathNo1 -= 1;
				}
			}
		}

		if (DeathNo2 == 0) {
			newPosition2 = Position0m;
		}
		if (DeathNo2 == 1) {
			newPosition2 = Position1m;
		}

		if (DeathNo == 0) {
			newPosition = Position0;
			}
		if (DeathNo == 1) {
			newPosition = Position1;
		}
		if (DeathNo == 2) {
			newPosition = Position2;
		}
		if (DeathNo == 3) {
			newPosition = Position3;
		}
		if (DeathNo == 4) {
			newPosition = Position4;
		}
		if (DeathNo == 5) {
			newPosition = Position5;
		}
		if (DeathNo == 6) {
			newPosition = Position6;
		}
		if (DeathNo == 7) {
			newPosition = Position7;
		}
		if (DeathNo == 8) {
			newPosition = Position8;
		}
		if (DeathNo == 9) {
			newPosition = Position9;
		}
		if (DeathNo == 10) {
			newPosition = Position10;
		}
		if (DeathNo == 11) {
			newPosition = Position11;
		}
		if (DeathNo == 12) {
			newPosition = Position12;
		}
		if (DeathNo == 13) {
			newPosition = Position13;
		}


		if (DeathNo1 == 0) {
			newPosition1 = Position0l;
		}
		if (DeathNo1 == 1) {
			newPosition1 = Position1l;
		}
		if (DeathNo1 == 2) {
			newPosition1 = Position2l;
		}
		if (DeathNo1 == 3) {
			newPosition1 = Position3l;
		}
		if (DeathNo1 == 4) {
			newPosition1 = Position4l;
		}
		if (DeathNo1 == 5) {
			newPosition1 = Position5l;
		}
		if (DeathNo1 == 6) {
			newPosition1 = Position6l;
		}
		if (DeathNo1 == 7) {
			newPosition1 = Position7l;
		}
		if (DeathNo1 == 8) {
			newPosition1 = Position8l;
		}
		if (DeathNo1 == 9) {
			newPosition1 = Position9l;
		}
		if (DeathNo1 == 10) {
			newPosition1 = Position10l;
		}
		if (DeathNo1 == 11) {
			newPosition1 = Position11l;
		}
		if (DeathNo1 == 12) {
			newPosition1 = Position12l;
		}
		if (DeathNo1 == 13) {
			newPosition1 = Position13l;
		}



		}
}
