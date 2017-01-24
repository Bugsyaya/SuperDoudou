using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {
	public GameObject prefab;
	public float duration = 2f;
	public bool isActivated;
	public float activatedTime;
	private GameObject shieldInstance;
	// Update is called once per frame
	void Update () {
		if(isActivated) {
			if(Time.time > activatedTime + duration) {
				Destroy(shieldInstance);
				isActivated = false;
			} else {
				shieldInstance.transform.position = gameObject.transform.position;
			}
		}
	}

	public void Activate() {
		if(!isActivated) {
			isActivated = true;
			shieldInstance = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
		}
		activatedTime = Time.time;
	}
}
