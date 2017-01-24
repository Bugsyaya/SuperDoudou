using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyPower : MonoBehaviour {
	public Power power;
	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player") power.applyOn(other.gameObject);
	}
}
