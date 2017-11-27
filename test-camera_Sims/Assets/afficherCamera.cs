using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class afficherCamera : MonoBehaviour
{
	private Camera surveillance;

	// Use this for initialization
	void Start()
	{
		surveillance = GetComponentInChildren<Camera>();
	}

	private void OnMouseDown()
	{
		surveillance.enabled = !surveillance.enabled;
	}
}
