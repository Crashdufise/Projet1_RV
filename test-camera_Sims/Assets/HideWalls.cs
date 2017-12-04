using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideWalls : MonoBehaviour {

	private FloorChange flrUp;
	private float height;
	public float hisHighness;
	private bool hidden;
	public GameObject wall;
	// Use this for initialization

	void Start () {
		flrUp = GameObject.Find("maison").GetComponent<FloorChange>();
		hisHighness = flrUp.pos;
		height = GetComponentInChildren<Renderer>().bounds.size.y;
	}
	
	// Update is called once per frame
	void Update () {
		if(!hidden){
			wall.transform.position = new Vector3(0, 1, 0);
	}
}
