using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleScript : MonoBehaviour {

    private Camera mainCamera;

	// Use this for initialization
	void Start () {
        mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.eulerAngles = mainCamera.transform.eulerAngles;
        float x = Input.mousePosition.x;
        float y = Input.mousePosition.y;
        Debug.Log(x + ";" + y);
    }
}
