using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class afficherTexteOnClick : MonoBehaviour {

    public Text tagText;
    public Text descriptionText;
    bool isToExplain;
    public string name;
    public string explain;

	// Use this for initialization
	void Start () {
        // trouver un moyen de "find" les textes
        isToExplain = false;
        tagText.text = "";
        descriptionText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2, 0));

        if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
        {
            if (hit.transform.gameObject == this.gameObject) isToExplain = true;
            else isToExplain = false;
        }
            
       

        if(isToExplain)
        {
            tagText.text = name;
            descriptionText.text = explain;
        }
    }
}
