using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class afficherCamera : MonoBehaviour {

    public Camera surveillance;
	bool isToShow;

	// Use this for initialization
	void Start () {
        isToShow = false;
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2, 0));

        if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
        {
			surveillance.enabled = !surveillance.enabled;
        }
}
