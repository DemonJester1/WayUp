using UnityEngine;
using System.Collections;

public class Light : MonoBehaviour {

	public float smooth = 5f;
	public float smooth1 = 5f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	

		if (transform.rotation.x >= 45f) {
			smooth = -5f;
		}
		if (transform.rotation.x <= -45f) {
			smooth = 5f;
		}
		if (transform.rotation.y >= 45f) {
			smooth1 = -5f;
		}
		if (transform.rotation.y <= -45f) {
			smooth1 = 5f;
		}
		transform.RotateAround (new Vector3 (0f, 14f, -37f), new Vector3 (1f, 0f, 0f), smooth * Time.deltaTime);
		transform.RotateAround (new Vector3 (0f, 14f, -37f), new Vector3 (0f, 1f, 0f), -smooth1 * Time.deltaTime);

	}
}
