using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyPower : MonoBehaviour {
	public Power power;

	void Start() {
		Debug.Log(gameObject.tag);
		switch(gameObject.tag) {
			case "JumpPower" : 
				power = new JumpPower();
				break;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("Trigger");
		if(other.tag == "Player") power.applyOn(other.gameObject);
	}
}
