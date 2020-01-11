using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paneles : MonoBehaviour {

    public GameObject vida, puntos, perder, apuntar;
    public bool panel;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {


        if (Time.timeScale == 0 && !panel)
        {
            vida.SetActive(true);
            panel = true;
        }
	}
    public void CambiarPuntos()
    {
        vida.SetActive(false);
        puntos.SetActive(true);
    }
    public void CambiarPerder()
    {
        puntos.SetActive(false);
        perder.SetActive(true);
    }
    public void CambiarTerminar()
    {
        perder.SetActive(false);
        Time.timeScale = 1;
    }
    public void CambiarTuto2()
    {
        apuntar.SetActive(false);
    }
}
