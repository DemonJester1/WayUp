using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCubes : MonoBehaviour {

	Renderer rend;
	float OfY;
	float OfX;
	Vector2 Off;
	Vector3 Movement;

	// Use this for initialization
	void Awake () {

		OfX = Random.Range (0f, 1f);
		OfY = Random.Range (0f, 1f);

		Off = new Vector2 (OfX, OfY);
	
		rend = GetComponent<Renderer> ();

		rend.material.mainTextureOffset = Off;

		Movement = transform.position;

		if (Movement.x == 8f) {
			Movement.x += Random.Range (0f, 1f);
			transform.position = Movement;
		}
		if (Movement.x == -8f) {
			Movement.x += Random.Range (-1f, 0f);
			transform.position = Movement;
		}
		if (Movement.y == 15f) {
			Movement.y += Random.Range (-1f, 0f);
			transform.position = Movement;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
