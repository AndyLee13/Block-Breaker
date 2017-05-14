using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Paddle paddle;
	private Vector3 paddleToBallVector; 
	private bool hasStarted = false;
	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			// Lock the ball relative to the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
		}

		//wait for a mouse click to launch
		if (Input.GetMouseButtonDown(0)) {
			hasStarted = true;
			this.rigidbody2D.velocity = new Vector2(2f,10f);
		}
	}
}
