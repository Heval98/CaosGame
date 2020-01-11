using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosJuego : MonoBehaviour {

    public GameObject ball;
    public int ConteoPorTurno; 
    public Text scorePlayerText;
    public int contadorP, ContadorControl, PuntosDelJuego;
    public AudioSource Explocion, perder;
    public PerderMenu aqui;
    public bool uno;
    public ShooterBehaviour Reiniciar;
    public Movimientoapuntar Reiniciar2;
    public GameObject nice, amazing, superb, galactic;
    public float timeCount;

    // Use this for initialization
    void Awake () {
        contadorP = 0;
        PuntosDelJuego = 0;
        ConteoPorTurno = 0;
        ContadorControl = 1;
        Explocion = GameObject.Find("Explocion").GetComponent<AudioSource>();
        perder = GameObject.Find("Perder").GetComponent<AudioSource>();
    }


        // Update is called once per frame
        void Update() {

        timeCount += Time.deltaTime;
        if (timeCount > 2.5f)
        {
            nice.SetActive(false);
            amazing.SetActive(false);
            superb.SetActive(false);
            galactic.SetActive(false);
        }

        ball = GameObject.FindGameObjectWithTag("Player");
        if(Reiniciar.controlBool || Reiniciar2.controlBool)
        {
            if(ConteoPorTurno == 2)
            {
                timeCount = 0;
                nice.SetActive(true);
                PuntosDelJuego += ConteoPorTurno + 1;
            }
            else if (ConteoPorTurno == 3)
            {
                timeCount = 0;
                amazing.SetActive(true);
                PuntosDelJuego += ConteoPorTurno * 2;
            }
            else if (ConteoPorTurno == 4)
            {
                timeCount = 0;
                superb.SetActive(true);
                PuntosDelJuego += ConteoPorTurno * 2;
            }
            else if (ConteoPorTurno > 4)
            {
                timeCount = 0;
                galactic.SetActive(true);
                PuntosDelJuego += ConteoPorTurno * 2;
            }
            else if (ConteoPorTurno == 1)
            {
                PuntosDelJuego += ConteoPorTurno;
            }
            
            ConteoPorTurno = 0;
        }


        if (aqui.condition && !uno)
        {
            Explocion.Stop();
            perder.Play();
            uno = true;
        }
 

        UpdateScoreLabel(scorePlayerText, PuntosDelJuego);
        
    }
    void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }

}
