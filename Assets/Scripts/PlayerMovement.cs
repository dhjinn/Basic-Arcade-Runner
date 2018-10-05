using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public Transform player;
	public float forwardForce = 2000f;

	public float sidewaysForce = 500f;
	public float jumpForce = 100f;


	void FixedUpdate () {
		

		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d") || Input.GetKey("right")){
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("a") || Input.GetKey("left")){
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if ((Input.GetKey("space") || Input.GetKey("up")) && player.position.y < 1.01 && player.position.y > 0.99) {
			rb.AddForce(0, jumpForce, 0);
		}
		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
