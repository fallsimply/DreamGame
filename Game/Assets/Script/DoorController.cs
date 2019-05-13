using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
	// Start is called before the first frame update

	void Start() {

	}

	// Update is called once per frame
	void Update() {

	}

	void OnCollisionEnter(Collision hit) {
		// if (hit.gameObject.CompareTag("Door")) {
		this.gameObject.transform.Rotate(0, -90f, 0);
		Debug.Log(ColliderHit);
		// }
	}
}
