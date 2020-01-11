using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerderMenu : MonoBehaviour {

    public GameObject disparo;
    public PuntosJuego traer;
    public GameObject publiboton;
    public static PerderMenu Instance;
    public Canvas pausamenuu;
    public LoseCondition cambio;
    public bool prueba;
    public bool destruira;
    public GameObject[] balls;
    public bool condition;
    public int PuntuacionLograda = 0;
    public PuntosJuego score;
    public string nivel;
    public GameObject newBall;
    public bool yaSeMostro;
    public int[] Scorejugadores = new int[6];
    public int[] Scorejugadoresno = new int[6];
    public CameraShake cameraShake;
    public Transform Camera1, Target;
    public Camera myCamera;

    // Use this for initialization
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        pausamenuu = GetComponent<Canvas>();
        pausamenuu.enabled = false;
        destruira = false;
        publiboton.SetActive(true);
        yaSeMostro = false;
    }
    void Start()
    {
        Scorejugadores[0] =
        PlayerPrefs.GetInt("puntuacionmaxima1");
        Scorejugadores[1] =
        PlayerPrefs.GetInt("puntuacionmaxima2");
        Scorejugadores[2] =
        PlayerPrefs.GetInt("puntuacionmaxima3");
        Scorejugadores[3] =
        PlayerPrefs.GetInt("puntuacionmaxima4");
        Scorejugadores[4] =
        PlayerPrefs.GetInt("puntuacionmaxima5");
        Scorejugadores[5] =
        PlayerPrefs.GetInt("puntuacionmaxima6");

        Scorejugadoresno[0] =
        PlayerPrefs.GetInt("nopuntuacionmaxima1");
        Scorejugadoresno[1] =
        PlayerPrefs.GetInt("nopuntuacionmaxima2");
        Scorejugadoresno[2] =
        PlayerPrefs.GetInt("nopuntuacionmaxima3");
        Scorejugadoresno[3] =
        PlayerPrefs.GetInt("nopuntuacionmaxima4");
        Scorejugadoresno[4] =
        PlayerPrefs.GetInt("nopuntuacionmaxima5");
        Scorejugadoresno[5] =
        PlayerPrefs.GetInt("nopuntuacionmaxima6");
    }



    // Update is called once per frame
    void Update() {
        if(pausamenuu.enabled)
        {
            Camera1.transform.position = new Vector3(0, 0, -10);   
            myCamera.orthographicSize = 5;
        }


        nivel = Application.loadedLevelName;

        if (nivel == "ModeOneDis")
        {
            PuntuacionLograda = score.PuntosDelJuego;
            if (PuntuacionLograda > PlayerPrefs.GetInt("puntuacionmaxima6"))
            {
                PlayerPrefs.SetInt("puntuacionmaxima6", PuntuacionLograda);
            }
        } else if (nivel == "ModeOne")
        {
            PuntuacionLograda = score.PuntosDelJuego;
            if (PuntuacionLograda > PlayerPrefs.GetInt("nopuntuacionmaxima6"))
            {
                PlayerPrefs.SetInt("nopuntuacionmaxima6", PuntuacionLograda);
            }
        }

        condition = pausamenuu.enabled;
        balls = GameObject.FindGameObjectsWithTag("Player");
        //  balls = GameObject.FindGameObjectsWithTag("GameController");
        foreach (GameObject ball in balls)
        {
            cambio = ball.GetComponent<LoseCondition>();
        }
        destruira = cambio.destruir;
        if (destruira)
        {
            StartCoroutine(cameraShake.Shake(.35f, .1f));
            prueba = true;
            pausamenuu.enabled = true;
            if (nivel == "TutoOne")
            {
                Destroy(disparo);
                Debug.Log("Entré a si");
            }
            else
            {
                disparo.SetActive(true);
                Debug.Log("Entré a no");
            }
            
        }
        
        if (Scorejugadores[5] > Scorejugadores[0])
        {
            Scorejugadores[4] = Scorejugadores[3];
            Scorejugadores[3] = Scorejugadores[2];
            Scorejugadores[2] = Scorejugadores[1];
            Scorejugadores[1] = Scorejugadores[0];
            Scorejugadores[0] = Scorejugadores[5];
            Scorejugadores[5] = 0;
        }
        else if (Scorejugadores[5] > Scorejugadores[1])
        {
            Scorejugadores[4] = Scorejugadores[3];
            Scorejugadores[3] = Scorejugadores[2];
            Scorejugadores[2] = Scorejugadores[1];
            Scorejugadores[1] = Scorejugadores[5];
            Scorejugadores[5] = 0;
        }
        else if (Scorejugadores[5] > Scorejugadores[2])
        {
            Scorejugadores[4] = Scorejugadores[3];
            Scorejugadores[3] = Scorejugadores[2];
            Scorejugadores[2] = Scorejugadores[5];
            Scorejugadores[5] = 0;
        }
        else if (Scorejugadores[5] > Scorejugadores[3])
        {
            Scorejugadores[4] = Scorejugadores[3];
            Scorejugadores[3] = Scorejugadores[5];
            Scorejugadores[5] = 0;
        }
        else if (Scorejugadores[5] > Scorejugadores[4])
        {
            Scorejugadores[4] = Scorejugadores[5];
            Scorejugadores[5] = 0;
        }

        if (Scorejugadoresno[5] > Scorejugadoresno[0])
        {
            Scorejugadoresno[4] = Scorejugadoresno[3];
            Scorejugadoresno[3] = Scorejugadoresno[2];
            Scorejugadoresno[2] = Scorejugadoresno[1];
            Scorejugadoresno[1] = Scorejugadoresno[0];
            Scorejugadoresno[0] = Scorejugadoresno[5];
            Scorejugadoresno[5] = 0;
        }
        else if (Scorejugadoresno[5] > Scorejugadoresno[1])
        {
            Scorejugadoresno[4] = Scorejugadoresno[3];
            Scorejugadoresno[3] = Scorejugadoresno[2];
            Scorejugadoresno[2] = Scorejugadoresno[1];
            Scorejugadoresno[1] = Scorejugadoresno[5];
            Scorejugadoresno[5] = 0;
        }
        else if (Scorejugadoresno[5] > Scorejugadoresno[2])
        {
            Scorejugadoresno[4] = Scorejugadoresno[3];
            Scorejugadoresno[3] = Scorejugadoresno[2];
            Scorejugadoresno[2] = Scorejugadoresno[5];
            Scorejugadoresno[5] = 0;
        }
        else if (Scorejugadoresno[5] > Scorejugadoresno[3])
        {
            Scorejugadoresno[4] = Scorejugadoresno[3];
            Scorejugadoresno[3] = Scorejugadoresno[5];
            Scorejugadoresno[5] = 0;
        }
        else if (Scorejugadoresno[5] > Scorejugadoresno[4])
        {
            Scorejugadoresno[4] = Scorejugadoresno[5];
            Scorejugadoresno[5] = 0;
        }

        PlayerPrefs.SetInt("puntuacionmaxima1", Scorejugadores[0]);
        PlayerPrefs.SetInt("puntuacionmaxima2", Scorejugadores[1]);
        PlayerPrefs.SetInt("puntuacionmaxima3", Scorejugadores[2]);
        PlayerPrefs.SetInt("puntuacionmaxima4", Scorejugadores[3]);
        PlayerPrefs.SetInt("puntuacionmaxima5", Scorejugadores[4]);
        PlayerPrefs.SetInt("puntuacionmaxima6", Scorejugadores[5]);

        PlayerPrefs.SetInt("nopuntuacionmaxima1", Scorejugadoresno[0]);
        PlayerPrefs.SetInt("nopuntuacionmaxima2", Scorejugadoresno[1]);
        PlayerPrefs.SetInt("nopuntuacionmaxima3", Scorejugadoresno[2]);
        PlayerPrefs.SetInt("nopuntuacionmaxima4", Scorejugadoresno[3]);
        PlayerPrefs.SetInt("nopuntuacionmaxima5", Scorejugadoresno[4]);
        PlayerPrefs.SetInt("nopuntuacionmaxima6", Scorejugadoresno[5]);

    }
    public void MostrarPanel()
    {
        pausamenuu.enabled = true;
    }
    public void quitarpanel()
    {
        pausamenuu.enabled = false;
        publiboton.SetActive(false);
        yaSeMostro = true;
    }
    public void quitarpanel2()
    {
        pausamenuu.enabled = false;
    }

    //public void VolverAPonerBoton()
    //{
    //    yaSeMostro = false;
    //}

}


