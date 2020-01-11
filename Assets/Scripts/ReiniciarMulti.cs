using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarMulti : MonoBehaviour {

    public float tiempo;
    public string nivel;

	// Use this for initialization
	void Start () {
        tiempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
        tiempo += Time.fixedDeltaTime;
        if(tiempo >= 1.5f)
        {
            SceneManager.LoadScene(nivel);
        }
	}
}
