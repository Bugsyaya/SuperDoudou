using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyPower : MonoBehaviour {

	delegate void Power(GameObject gameObject);
	private Power power;

	private bool canDoubleJump;

	void Start() {
		Debug.Log(gameObject.tag);
		switch(gameObject.tag) {
			case "JumpPower" : 
				power = go => {
					if(Model.Instance.canJump) {
						Model.Instance.canJump = false;
						go.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 600));
					}
				};break;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player") power(other.gameObject);
	}
}
