using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBall : MonoBehaviour {

	public float speed;
	Vector3 newPosition;
	public float timer;

	// Use this for initialization
	void Start () {

		newPosition = transform.position;
		timer = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (timer);

		transform.position = Vector3.MoveTowards (transform.position, newPosition, speed * Time.deltaTime);

		timer -= Time.deltaTime;

		if (transform.position.z == -28f && timer <= 0 && timer > -0.5f) {
			newPosition = new Vector3 (0,2f,-22.5f);
			speed = 5.5f;
			timer = 1.5f;
		}
		if (transform.position.z == -22.5f && timer <= 0 && timer > -0.5f) {
			newPosition = new Vector3 (0,2f,-14.5f);
			speed = 8f;
			timer = 1.5f;
		}
		if (transform.position.z == -14.5f && timer <= 0 && timer > -0.5f) {
			newPosition = new Vector3 (0,2f,-2.5f);
			speed = 12f;
			timer = 1.5f;
		}
		if (transform.position.z == -2.5f && timer <= 0 && timer > -0.5f) {
			newPosition = new Vector3 (0,2f,16f);
			speed = 18.5f;
		}
		if (transform.position.z == 16f && timer <= -1.5f) {
			newPosition = new Vector3 (0,2f,-2.5f);
			speed = 18.5f;
			timer = -0.5f;
		}
		if (transform.position.z == 16f && timer <= 0 && timer > -0.5f) {
			newPosition = new Vector3 (0,2f,-2.5f);
			speed = 18.5f;
			timer = -0.5f;
		}
		if (transform.position.z == -2.5f && timer <= -2f) {
			newPosition = new Vector3 (0,2f,-14.5f);
			speed = 12f;
			timer = -0.5f;
		}
		if (transform.position.z == -14.5f && timer <= -2f) {
			newPosition = new Vector3 (0,2f,-22.5f);
			speed = 8f;
			timer = -0.5f;
		}
		if (transform.position.z == -22.5f && timer <= -2f) {
			newPosition = new Vector3 (0,2f,-28f);
			speed = 5f;
			timer = 1.5f;
		}
	}
}
