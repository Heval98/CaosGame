using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMenu3 : MonoBehaviour {

    Canvas canvas;
    public Pause3 cuerpo;
    public bool amenu;


	// Use this for initialization
	void Start () {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        
    }
	
	// Update is called once per frame
	void Update () {

        amenu = cuerpo.active;
        canvas.enabled = amenu;

    }
}
