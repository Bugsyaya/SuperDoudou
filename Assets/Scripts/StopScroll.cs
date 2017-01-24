using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopScroll : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Player")) {
			Debug.Log("StoScroll");
			Model.Instance.scrolling = false;
			Rigidbody2D rb2d = other.gameObject.GetComponent<Rigidbody2D>();
			Vector2 velocity = rb2d.velocity;
			velocity.x = 0;
			rb2d.velocity = velocity;
		}
	}
}
