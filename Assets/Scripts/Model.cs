using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour {
	private static Model _instance = null;
	public static Model Instance {get { return _instance; }}


	public bool canJump = true;
	public float maxSpeed = 100f;

	void Awake() {
		if(_instance != null && _instance != this) Destroy(this);
		else {
			_instance = this;
		}
	}
}
