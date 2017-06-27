using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

	public float paddleSpeed = 1f;
	public float maxMovementWidth = 8;

	private Transform playerPos;
	private float xPos;

	// Use this for initialization
	void Start () {

		playerPos = this.transform;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed);
		playerPos.position = new Vector3 (Mathf.Clamp (xPos, -maxMovementWidth, maxMovementWidth), playerPos.position.y, playerPos.position.z);

	}
}
