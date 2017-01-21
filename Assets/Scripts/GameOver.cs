using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag != "Player") SceneManager.LoadScene("GameOver");
	}
}
