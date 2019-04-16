using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour {

	private float delayTimer;
	float timer;
	public GameObject Ground;


	// Use this for initialization
	void Awake(){
		Instantiate (Ground, transform.position, transform.rotation);
		delayTimer = 0.7f;
	}
	void Start () {
		timer = delayTimer;
	}

	// Update is called once per frame
	void Update () {



		timer -= Time.deltaTime;
		if (timer <= 0) {
			Instantiate (Ground, transform.position, transform.rotation);
			timer = delayTimer;
		}
	}
}
