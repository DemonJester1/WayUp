using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour {

	private float gone = 7f;
	private float speed = 20f;
	private float speedx;
	private Vector3 move;

	// Use this for initialization
	void Start () {

		speedx = Random.Range (40f, 80f);

		move = new Vector3 (transform.position.x, transform.position.y, -100f);

	}

	// Update is called once per frame
	void Update () {

		transform.position = Vector3.MoveTowards (transform.position, move, speed * Time.deltaTime);

		transform.RotateAround (transform.position, new Vector3 (0, 1, 0), speedx * Time.deltaTime);

		gone -= Time.deltaTime;

		if (gone < 0) {
			Destroy (gameObject);
		}
	}
}
