using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpReset : MonoBehaviour {
	public bool isGrounded {get { return Model.Instance.grounded;}}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Player")) {
			Model.Instance.canJump = true;
			Model.Instance.grounded = true;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if(other.CompareTag("Player")) Model.Instance.grounded = false;
	}
}
