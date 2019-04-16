using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject Money;
	private float delayTimer1 = 2f;
	float timer1 = 1f;
	private Vector3 newPosition;
	int CoinPos;
	public Spawner sp;

	// Use this for initialization
	void Start () {

		sp = FindObjectOfType<Spawner> ();

		transform.position = newPosition;

		timer1 = delayTimer1;

		CoinPos = Random.Range (0, 3);

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 Position0 = new Vector3 (0f, 0f, 100f);
		Vector3 Position1 = new Vector3 (5.7f, 0f, 80f);
		Vector3 Position2 = new Vector3 (-5.7f, 0f, 80f);

		if (CoinPos == 0 && sp.DeathNo <= -1) {
			newPosition = Position1;
		} else {
			newPosition = Position0;
		}
		if (CoinPos == 1) {
			newPosition = Position1;
		}
		if (CoinPos == 2) {
			newPosition = Position2;
		}

	
		timer1 -= Time.deltaTime;
		if (timer1 <= 0) {
			Instantiate (Money,newPosition,transform.rotation);
			CoinPos = Random.Range (0, 3);
			timer1 = delayTimer1;
		}
	}
}
