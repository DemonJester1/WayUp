using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {

	private float gone = 7f;
	private float speed = 14f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		gone -= Time.deltaTime;

		if (gone < 0) {
			Destroy (gameObject);
		}

		transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime);

	}
}
