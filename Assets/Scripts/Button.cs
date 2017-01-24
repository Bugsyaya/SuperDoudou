using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
	public Sprite enabledSprite;
	public Sprite disabledSprite;

	private SpriteRenderer spriteRenderer;

	void Awake() {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	public void Enable() {
		gameObject.GetComponent<SpriteRenderer>().sprite = enabledSprite;
	}

	public void Disable() {
		spriteRenderer.sprite = disabledSprite;
	}
}
