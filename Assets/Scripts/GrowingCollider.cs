using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingCollider : MonoBehaviour {
	public float duration = 2f;
	public float max = 20f;
	public float min = 0f;


	private CircleCollider2D circleCollider2D;
	public float speed;

	void Awake() {
		circleCollider2D = GetComponent<CircleCollider2D>();
		speed = (max - min) / duration;
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		if(circleCollider2D.radius < max) circleCollider2D.radius += (Time.fixedDeltaTime * speed);
	}
}
