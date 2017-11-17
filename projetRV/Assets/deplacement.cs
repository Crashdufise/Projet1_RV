using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour {

    public float speed;
    public float speed2;
    public float speedRotation;
    


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.forward * speed * Input.GetAxis("Mouse ScrollWheel"));
        transform.Translate(transform.right * speed2 * Input.GetAxis("Horizontal"));
        transform.Translate(transform.up * speed2 * Input.GetAxis("Vertical"));

        float rotX = transform.eulerAngles.x - Input.GetAxis("Mouse Y") * speedRotation;
        // float rotY = Mathf.Clamp(transform.eulerAngles.y + Input.GetAxis("Mouse X") * speedRotation, 10f, -50f);
        float rotY = transform.eulerAngles.y + Input.GetAxis("Mouse X") * speedRotation;
        // transform.eulerAngles = new Vector3(rotX, rotY, 0);
    }
}
