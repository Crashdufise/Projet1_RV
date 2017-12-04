using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSurveillance : MonoBehaviour {
	public Camera camSurv;
	// Use this for initialization
	void Start () {
		camSurv = GetComponentInChildren<Camera>();
	}
	
	void OnMouseDown () {
		camSurv.enabled = !camSurv.enabled;
	}
}
