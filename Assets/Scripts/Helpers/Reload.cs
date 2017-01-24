using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour {
	public void ReloadStage() {
		SceneManager.LoadScene(Persisted.Instance.currentLevel);
	}

	public void ReloadGame(){
		SceneManager.LoadScene("Intro");
	}
}
