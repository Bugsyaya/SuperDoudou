using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickListener : MonoBehaviour {
	public GameObject spawner;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")) {
			Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			clickPosition.z = 0;
			Instantiate(spawner, clickPosition, Quaternion.identity);
		}
		
	}


}
