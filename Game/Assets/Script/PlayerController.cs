using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public UIController UIController;

	void OnParticleCollision(GameObject other) {
		Debug.Log("Hit Particle");
		if (other.CompareTag("Fire")) {
			UIController.Lose();
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Exit")) {
			UIController.Win();
		}
		if (other.CompareTag("Fire")) {
			UIController.Lose();
		}
	}
}
