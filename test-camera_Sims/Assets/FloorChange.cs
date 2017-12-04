using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorChange : MonoBehaviour
{

	private int compt;
	public int pos;
	private int numFloors;
	public GameObject[] floors;
	public GameObject pivot;

	public void monter()
	{
		compt--;
		compt = Mathf.Clamp(compt, 0, numFloors-1);
		pivot.transform.position = new Vector3(transform.position.x, pos * GetComponentInChildren<Renderer>().bounds.size.y, transform.position.z);
	}

	public void descendre()
	{
		compt++;
		compt = Mathf.Clamp(compt, 0, numFloors-1);
		pivot.transform.position = new Vector3(transform.position.x, (pos-1)* GetComponentInChildren<Renderer>().bounds.size.y, transform.position.z);
	}

	// Use this for initialization
	void Start()
	{
		//floors = GameObject.FindGameObjectsWithTag("floor");
		numFloors = floors.Length;
	}

	// Update is called once per frame
	void Update()
	{
		for (int i = 0; i < compt; i++) floors[i].SetActive(false);

		for (int j = compt; j < numFloors; j++) floors[j].SetActive(true);
		pos = (numFloors - compt);
	}
}