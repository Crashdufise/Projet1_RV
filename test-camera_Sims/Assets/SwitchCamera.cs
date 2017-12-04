using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchCamera : MonoBehaviour {
	public Camera cameraFly;
	public Camera camera1st;

	// Use this for initialization
	void Start () {
		cameraFly.enabled = false;
		camera1st.enabled = true;
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(Switch);
	}
	
	// Update is called once per frame
	void Switch () {
			cameraFly.enabled = !cameraFly.enabled;
			camera1st.enabled = !camera1st.enabled;
	}	
}
