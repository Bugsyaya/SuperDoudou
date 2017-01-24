using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Model : MonoBehaviour {
	public bool tuto = false;
	private static Model _instance = null;
	public static Model Instance {get { return _instance; }}
	public GameObject jumpPower, shieldPower, shotPower,
					  jumpButton, shieldButton, shotButton;

	private Power[] powers;
	public Power currentPower;


	public bool canJump = true;
	public float maxSpeed = 100f;
	public bool grounded = false;
	public bool scrolling = true;


	void Awake() {
		if(_instance != null && _instance != this) Destroy(this);
		else {
			_instance = this;
			Constructor();
		}
	}

	void Start() {
		currentPower = powers[0];
		jumpButton.GetComponent<Button>().Enable();
		Persisted.Instance.currentLevel = SceneManager.GetActiveScene().name;
	}

	void Constructor() {
		powers = new Power[] {
			new Power(jumpPower, go => {
				if(canJump) {
					canJump = false;
					go.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,600));
				}
			}),
			new Power(shieldPower, go => go.GetComponent<Shield>().Activate()),
			new Power(shotPower, go => go.GetComponent<WeaponScript>().Attack(false))
		};
		currentPower = powers[0];
	}

	void Update() {
		if(Input.GetButtonDown("Jump")) {
			currentPower = powers[0];
			jumpButton.GetComponent<Button>().Enable();
			if(!tuto) {
				shieldButton.GetComponent<Button>().Disable();
				shotButton.GetComponent<Button>().Disable();
			}
		} else if(!tuto) {
			if(Input.GetButtonDown("Fire2")) {
				currentPower = powers[1];
				jumpButton.GetComponent<Button>().Disable();
				shieldButton.GetComponent<Button>().Enable();
				shotButton.GetComponent<Button>().Disable();
			} else if (Input.GetButtonDown("Fire3")) {
				currentPower = powers[2];
				jumpButton.GetComponent<Button>().Disable();
				shieldButton.GetComponent<Button>().Disable();
				shotButton.GetComponent<Button>().Enable();
			}
		}
	}
}