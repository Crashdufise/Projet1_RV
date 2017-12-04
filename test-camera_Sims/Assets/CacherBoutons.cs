using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CacherBoutons : MonoBehaviour {
	
	public GameObject pivot;
	public GameObject up;
	public GameObject down;
	public GameObject walls;

	// Update is called once per frame
	void Update () {

		if (Camera.main != pivot.GetComponentInChildren<Camera>())
		{
			up.SetActive(false);
			down.SetActive(false);
			walls.SetActive(false);
		}
		else
		{
			up.SetActive(true);
			down.SetActive(true);
			walls.SetActive(true);
		}

	}
}
