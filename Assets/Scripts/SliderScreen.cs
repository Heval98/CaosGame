using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScreen : MonoBehaviour {

    public Touch touch;
    public Vector3 dedoPos, antes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Moved)
            {
                dedoPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            if (touch.phase == TouchPhase.Began)
            {
                antes = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }

        if(dedoPos.x >= (antes.x + 0.5f))
        {

        }

	}

}
