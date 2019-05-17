using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AutoFocus : MonoBehaviour {
	// Start is called before the first frame update
	void Start() {
		EventSystem eventSys = EventSystem.current;
		eventSys.SetSelectedGameObject(this.gameObject);
	}
}
