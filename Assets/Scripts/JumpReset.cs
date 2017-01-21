using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpReset : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player") Model.Instance.canJump = true;
	}
}
