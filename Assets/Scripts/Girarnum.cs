using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girarnum : MonoBehaviour {

    public ShooterBehaviour2 band;
    public ShooterBehaviour3 band2;
    public SpriteRenderer este;

	// Use this for initialization
	void Start () {
       este = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (band.dir && !band2.dir)
        {
            este.flipY = false;
            este.flipX = false;
        }
        else if (!band.dir && band2.dir)
        {
            este.flipY = true;
            este.flipX = true;
        }
        
	}
}
