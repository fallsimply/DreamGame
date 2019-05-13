using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public UIController UIController;

	void OnParticleCollision(GameObject other) {
		if (other.CompareTag("Fire")) {
			UIController.Lose();
		}
	}
}
