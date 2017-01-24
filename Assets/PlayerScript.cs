using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	private WeaponScript weapon;

	// Use this for initialization
	void Start () {
		weapon = GetComponent<WeaponScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
