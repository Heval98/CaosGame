using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 newPosition = target.position;
        newPosition.z = 0;
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
	}
}
