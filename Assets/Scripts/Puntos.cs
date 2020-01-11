using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

    public static Puntos Records;
    public Text PuntosMa;
    public Text PuntosMa2;
    public Text PuntosMa3;
    public Text PuntosMa4;
    public Text PuntosMa5;
    public Text noPuntosMa;
    public Text noPuntosMa2;
    public Text noPuntosMa3;
    public Text noPuntosMa4;
    public Text noPuntosMa5;
    public int[] Scorejugadores = new int[6];
    public int[] Scorejugadoresno = new int[6];

    void Awake()
    {

    }

    // Use this for initialization
    void Start () {
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
	void Update () {

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

        PuntosMa.text = 
        PlayerPrefs.GetInt("puntuacionmaxima1").ToString();
        PuntosMa2.text =
        PlayerPrefs.GetInt("puntuacionmaxima2").ToString();
        PuntosMa3.text =
        PlayerPrefs.GetInt("puntuacionmaxima3").ToString();
        PuntosMa4.text =
        PlayerPrefs.GetInt("puntuacionmaxima4").ToString();
        PuntosMa5.text =
        PlayerPrefs.GetInt("puntuacionmaxima5").ToString();

        noPuntosMa.text =
        PlayerPrefs.GetInt("nopuntuacionmaxima1").ToString();
        noPuntosMa2.text =
        PlayerPrefs.GetInt("nopuntuacionmaxima2").ToString();
        noPuntosMa3.text =
        PlayerPrefs.GetInt("nopuntuacionmaxima3").ToString();
        noPuntosMa4.text =
        PlayerPrefs.GetInt("nopuntuacionmaxima4").ToString();
        noPuntosMa5.text =
        PlayerPrefs.GetInt("nopuntuacionmaxima5").ToString();

    }
}
