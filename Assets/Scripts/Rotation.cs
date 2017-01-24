using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
	public Vector3 rotation = new Vector3(0, 0, 180);
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate(rotation * Time.deltaTime);
	}
}
