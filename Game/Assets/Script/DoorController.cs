using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
	public float RotateDeg = -90f;
	public bool Enabled = true;
	private Material Mat;

	void Start() {
		Mat = GetComponentInChildren<Renderer>().material;

		if (!Enabled) {
			Mat.color = Color.black;
		}
	}

	void OnCollisionEnter(Collision hit) {
		if (!Enabled) return;
		this.gameObject.transform.Rotate(0, -90f, 0);
	}
}
