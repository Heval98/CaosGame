using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReiniciarPuntos : MonoBehaviour {


	
	// Update is called once per frame
	public void Reini () {
        PlayerPrefs.DeleteKey("Jugador1");
        PlayerPrefs.DeleteKey("Jugador2");
    }
}
