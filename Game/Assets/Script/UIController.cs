using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {
	public void Lose() {
		SceneManager.LoadScene("Lose");
	}

	public void Game() {
		SceneManager.LoadScene("Main");
	}

	public void Win() {
		SceneManager.LoadScene("Win");
	}

	public void Menu() {
		SceneManager.LoadScene("Menu");
	}

	public void Quit() {
		Application.Quit();
	}
}
