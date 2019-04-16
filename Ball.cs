using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	private float smooth = 12f;
	private Vector3 newPosition;
	public UiManager ui;
	private int move;
	private int value = 1;
	public bool shielding;
	public MoneyManager theMM;
	float fuck;
	//float fucky;


	// Use this for initialization
	void Start () {
			
		theMM = FindObjectOfType<MoneyManager> ();
		ui = FindObjectOfType<UiManager> ();

		shielding = false;

		newPosition = transform.position;

		move = 0;

		fuck = transform.position.x;

		//fucky = transform.position.y;

	
	}
	
	// Update is called once per frame
		
	void Update () {

		Debug.Log (newPosition);

		newPosition.y = transform.position.y;

		//if (transform.position.y != fucky) {
		//	transform.Translate (new Vector3 (0, -1, 0) * Time.deltaTime);
		//}

		if (transform.position.x > fuck) {
			transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime);
		}
		if (transform.position.x < -fuck) {
			transform.Translate (new Vector3 (1, 0, 0) * Time.deltaTime);
		}

		if (transform.position.z  <  -16f && shielding == false) {
			ui.gameOverActivated ();
			Destroy (gameObject);
		}

		if (transform.position.z  !=  -16f && shielding == true) {
			SceneManager.LoadScene("level");
		}

		Vector3 PositionA = new Vector3 (fuck, transform.position.y, transform.position.z);
		Vector3 PositionB = new Vector3 (-fuck, transform.position.y, transform.position.z);

	transform.position = Vector3.MoveTowards (transform.position, newPosition, smooth * Time.deltaTime);
		if (move == 1 && transform.position != PositionA) {
			transform.Rotate (Vector3.forward, 360 * smooth * Time.deltaTime);
		}
		if (move == 2 && transform.position != PositionB) {
			transform.Rotate (Vector3.forward, -360 * smooth * Time.deltaTime);
		}


//		if(Input.GetKeyDown(KeyCode.DownArrow) && move == 0){
//			newPosition = PositionB;
//		}
//		if(Input.GetTouch(0).phase == TouchPhase.Began && move == 0){
//			newPosition = PositionB;
//		}
		if (transform.position == PositionA && move == 2) {
		newPosition = PositionB;
		}
		if (transform.position == PositionB && move == 1) {
			newPosition = PositionA;
		}
		if (smooth == 0 && (newPosition.x+transform.position.x) >= 0 && move == 2) {
			newPosition = PositionB;
			smooth = 12f;
		}
		if (smooth == 0 && (newPosition.x+transform.position.x) <= 0 && move == 1) {
			newPosition = PositionA;
			smooth = 12f;
		}
/*		if(Input.GetKeyDown (KeyCode.DownArrow) && move == 0 && newPosition == transform.position){
			Move1 ();
		}
		if (Input.GetKeyDown (KeyCode.DownArrow) && move == 1 && (newPosition.x + transform.position.x) >= 0) {
			Move2 ();
		}
		if (Input.GetKeyDown (KeyCode.DownArrow) && move == 2 && (newPosition.x + transform.position.x) <= 0) {
			Move1 ();
		}*/
		if(Input.GetTouch(0).phase == TouchPhase.Began && move == 0 && newPosition == transform.position){
			move = 1;
		}
		if (Input.GetTouch(0).phase == TouchPhase.Began && move == 1 && (newPosition.x + transform.position.x) >= 0) {
			move = 2;
		}
		if (Input.GetTouch(0).phase == TouchPhase.Began && move == 2 && (newPosition.x + transform.position.x) <= 0) {
			move = 1;
		}
	}

	public void Move1(){
		move = 1;
	}
	public void Move2(){
		move = 2;
	}

	void OnCollisionEnter(Collision col){

		if(newPosition.x == -fuck && col.gameObject.transform.position.x < this.gameObject.transform.position.x){
			smooth = 0f;
		}

		if(newPosition.x == fuck && col.gameObject.transform.position.x > this.gameObject.transform.position.x){
			smooth = 0f;
		}
			
	}

	void OnCollisionExit(Collision col){
			smooth = 12f;

	}
	void OnTriggerEnter(Collider pol){

		if (pol.gameObject.tag == "Death" && shielding == false) {
			Destroy (gameObject);
			ui.gameOverActivated ();
		}
		if (pol.gameObject.tag == "Death" && shielding == true) {
			SceneManager.LoadScene("level");
		}
		if (pol.gameObject.tag == "Money") {
			Destroy (pol.gameObject);
			theMM.AddMoney (value);
		}
	}
}
