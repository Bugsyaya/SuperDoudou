using UnityEngine;

public class GrowingScale : MonoBehaviour {
	public float duration = 2f;
	public float max = 20f;
	public float min = 0f;

	public float speed;

	void Awake() {
		speed = (max - min) / duration;
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		if(transform.localScale.x < max) {
			transform.localScale = new Vector2(
				transform.localScale.x + Time.fixedDeltaTime * speed,
				transform.localScale.y + Time.fixedDeltaTime * speed
			);
		} else {
			Destroy(gameObject);
		}
	}
}
