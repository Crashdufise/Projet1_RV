using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
	public Camera cameraFly;
	public GameObject maison;
	public bool isManu;
	public float speedAuto = 10;
	public float speedManu = 50;
	public float speedZoom1 = 5000;
	public float speedZoom2;
	private float valMinY; // la valeur en dessous de laquelle le bloc peut rotisser
	private Camera Camera;
	int sens = 1; // 0:rien -1:gauche 1:droite
	private float maxValY; // la hauteur max que peut atteindre le bloc Caméra

	// Use this for initialization
	void Start()
	{
		Camera = cameraFly;
		Camera.transform.eulerAngles = new Vector3(0, 0, 0);
		Camera.transform.position = new Vector3(0,0, maison.GetComponent<Renderer>().bounds.size.y * (-4f));
		transform.eulerAngles = new Vector3(0, 0, 0);
		transform.position = new Vector3(0, 0, 0);
		isManu = false;
		valMinY = maison.GetComponent<Renderer>().bounds.size.y;
		speedZoom1 = 50;
		maxValY = valMinY * 3;
		speedZoom2 = valMinY * 70;

		float rotX = Mathf.Clamp(transform.eulerAngles.x + Input.GetAxis("Mouse ScrollWheel") * speedZoom1, 30, 90);
		transform.eulerAngles = new Vector3(rotX, transform.eulerAngles.y, transform.eulerAngles.z);
	}

	void zoom()
	{
		if (transform.position.y < valMinY)
		{
			float rotX = Mathf.Clamp(transform.eulerAngles.x + Input.GetAxis("Mouse ScrollWheel") * speedZoom1, 30, 90);
			transform.eulerAngles = new Vector3(rotX, transform.eulerAngles.y, transform.eulerAngles.z);
		}


		transform.Translate(0, Input.GetAxis("Mouse ScrollWheel") * speedZoom2 * Time.deltaTime, 0, Space.World);
		transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 0, maxValY), transform.position.z);
	}

	void rotManu()
	{
		if (Input.GetMouseButton(0))
		{
			transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * speedManu * Time.deltaTime);
		}
	}


	void rotAuto()
	{

		if (Input.GetKey("left"))
		{
			sens = -1;
		}
		if (Input.GetKey("right"))
		{
			sens = 1;
		}
		if (Input.GetKey("space"))
		{
			sens = 0;
		}
		if (Input.GetAxis("Mouse ScrollWheel") > 0f)
		{
			Debug.Log("Scroll");
		}
		transform.RotateAround(transform.position, Vector3.up, sens * speedAuto * Time.deltaTime);
	}

	// Update is called once per frame
	void Update()
	{
			if (Input.GetKey("m"))
			{
				isManu = !isManu;
			}
			if (isManu) { rotManu(); }
			if (!isManu) { rotAuto(); }
			if (Input.GetAxis("Mouse ScrollWheel") != 0) { zoom(); }
	}
}
