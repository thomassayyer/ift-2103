using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour {

	public void Play() {
		SceneManager.LoadScene("Play/Play");
	}

	public void Back() {
		SceneManager.LoadScene("Menu/Menu");
	}
}
