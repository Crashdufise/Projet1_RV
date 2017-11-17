using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour {
	public Camera cameraFly;
	public Camera camera1st;

	// Use this for initialization
	void Start () {
		cameraFly.enabled = false;
		camera1st.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("c"))
		{
			cameraFly.enabled = !cameraFly.enabled;
			camera1st.enabled = !camera1st.enabled;
		}
	}
}
