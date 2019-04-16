using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSp : MonoBehaviour {

	private float delayTimer = 2f;
	float timer;
	public GameObject Plane;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer <= 0) {
			Instantiate (Plane, transform.position, transform.rotation);
			timer = delayTimer;
		}
	}
}
