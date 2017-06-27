using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public float ballStartingSpeed = 500.0f;

	private Rigidbody myRigidBody;
	private bool isPlaying = false;

	// Use this for initialization
	void Start () {

		myRigidBody = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Jump") && !isPlaying) {

			transform.parent = null;
			isPlaying = true;
			myRigidBody.AddForce (new Vector3 (ballStartingSpeed, ballStartingSpeed, 0));

		}
		
	}
		
}
