using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosJuego2 : MonoBehaviour {

    public Text scorePlayerText;
    public int contadorP, ContadorControl;
    public AudioSource Explocion, perder;
    public PerderMenu3 aqui;
    public bool uno;

    // Use this for initialization
    void Awake () {
        contadorP = 0;
        ContadorControl = 1;
        Explocion = GameObject.Find("Explocion").GetComponent<AudioSource>();
        perder = GameObject.Find("Perder").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

        if (aqui.condition && !uno)
        {
            Explocion.Stop();
            perder.Play();
            uno = true;
        }
 
        if (contadorP == ContadorControl)
        {
            
            Explocion.Play();
            ContadorControl++;
        }

        UpdateScoreLabel(scorePlayerText, contadorP);
        
    }
    void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }

}
