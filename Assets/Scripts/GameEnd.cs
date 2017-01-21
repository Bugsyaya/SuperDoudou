using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour {
	public string scene;

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player") SceneManager.LoadScene(scene);
	}
}
