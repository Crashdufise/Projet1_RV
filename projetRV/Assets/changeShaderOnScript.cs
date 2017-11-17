using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeShaderOnScript : MonoBehaviour {

    public Shader shader;
    public Shader shaderHighlighted;
    private Camera mainCamera;
    private Renderer rend;

	// Use this for initialization
	void Start () {
        mainCamera = Camera.main;
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2, 0));



        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject == this.gameObject)
            {
                rend.material.shader = shaderHighlighted;
            }
            else
            {
                rend.material.shader = shader;
            }
        }
        else
        {
            rend.material.shader = shader;
        }
    }
}
