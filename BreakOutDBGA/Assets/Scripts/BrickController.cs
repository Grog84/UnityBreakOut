using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour {

	private bool isHit = false;

	void LateUpdate () {
		if (isHit == true) {
			this.gameObject.SetActive (false);
		}
	}

	void OnCollisionEnter(Collision other){
		setHitStatus ();
	}

	void setHitStatus(){
		isHit = true;
	}
}
