using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarPuntos : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.DeleteKey("Jugador1");
        PlayerPrefs.DeleteKey("Jugador2");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
