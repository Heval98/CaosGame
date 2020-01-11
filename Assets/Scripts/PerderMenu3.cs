using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerderMenu3 : MonoBehaviour {

    public Canvas pausamenuu;
    public LoseCondition2 cambio;
    public bool prueba;
    public bool destruira;
    public GameObject[] balls;
    public bool condition;
    public BoxCollider2D arriba;
    public BoxCollider2D abajo;
    public int Ju1=0, Ju2=0;
    public bool iniciar;
    public GameObject marcador, marcadorGanador;
    public Text Texto1, Texto2, Texto3, Texto4,TextoJu1,TextoJu2;
    public IdiomaGlobal idiomaGlobal;
    public string ganador, perdedor;
    public Transform Camera1, Target;
    public Camera myCamera;
    public CameraShake cameraShake;

    // Use this for initialization
    void Awake () {
        pausamenuu = GetComponent<Canvas>();
        pausamenuu.enabled = false;
        destruira = false;
        Ju1 = PlayerPrefs.GetInt("Jugador1");
        Ju2 = PlayerPrefs.GetInt("Jugador2");
        iniciar = true;
        marcador.SetActive(false);
    }
    void Start()
    {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (pausamenuu.enabled)
        {
            Camera1.transform.position = new Vector3(0, 0, -10);
            myCamera.orthographicSize = 5;
        }

        if (idiomaGlobal.RetornaIdioma() == "Ingles")
        {
            ganador = "WINNER!";
            perdedor = "LOSER!";
        }
        else if (idiomaGlobal.RetornaIdioma() == "Español")
        {
            ganador = "GANADOR!";
            perdedor = "PERDEDOR!";
        }


        Texto1.text = Ju2.ToString();
        Texto2.text = Ju1.ToString();
        Texto3.text = Ju2.ToString();
        Texto4.text = Ju1.ToString();
        if (Ju1 >= 3 || Ju2 >= 3)
        {
            if (Ju1 >= 3)
            {
                TextoJu1.text = ganador;
                TextoJu2.text = perdedor;
            }else if (Ju2 >= 3)
            {
                TextoJu2.text = ganador;
                TextoJu1.text = perdedor;
            }
            marcador.SetActive(false);
            marcadorGanador.SetActive(true);
            Invoke("devolverBotones", 1.5f);
            PlayerPrefs.DeleteKey("Jugador1");
            PlayerPrefs.DeleteKey("Jugador2");
        }
        

        condition = pausamenuu.enabled;
        balls = GameObject.FindGameObjectsWithTag("Player");
      //  balls = GameObject.FindGameObjectsWithTag("GameController");
        foreach (GameObject ball in balls)
        {
            cambio = ball.GetComponent<LoseCondition2>();
        }
        destruira = cambio.destruir;
        if (destruira && abajo.isTrigger && iniciar)
        {
            StartCoroutine(cameraShake.Shake(.35f, .1f));
            Ju1++;
            prueba = true;
            PlayerPrefs.SetInt("Jugador1", Ju1);
            iniciar = false;
            marcador.SetActive(true);
        }
        if (destruira && arriba.isTrigger && iniciar)
        {
            StartCoroutine(cameraShake.Shake(.35f, .1f));
            Ju2++;
            prueba = true;
            PlayerPrefs.SetInt("Jugador2", Ju2);
            iniciar = false;
            marcador.SetActive(true);
        } 

    }
    void devolverBotones()
    {
        
        pausamenuu.enabled = destruira;
        marcadorGanador.SetActive(false);
        Ju1 = 0;
        Ju2 = 0;
    }
}


