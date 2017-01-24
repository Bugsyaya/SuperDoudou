using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persisted : MonoBehaviour {
	private static Persisted _instance = null;
	public static Persisted Instance { get { return _instance; } }

	public string currentLevel = "Marina";

	void Awake() {
		if(_instance != null && _instance != this) Destroy(gameObject);
		else {
			_instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
