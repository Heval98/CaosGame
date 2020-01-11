using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoDestruir : MonoBehaviour {

    public static NoDestruir VolumenJ;
    public AudioSource uno, dos;
    public string nivel;
    public bool quitar, quitar2;

    // Use this for initialization
    void Awake () {
        quitar = true;
        if (VolumenJ == null)
        {
            VolumenJ = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (VolumenJ != this)
        {
            Destroy(gameObject);
        }
    }

    void start()
    {
        
    }
    
    void Update ()
    {
        nivel = Application.loadedLevelName;
        if (nivel == "MainMenu" && quitar)
        {
            quitar2 = true;
            PlayOne(); 
            quitar = false;
            
        }
        if (nivel == "ModeMultiDis" && quitar2 || nivel == "ModeMultiplayer" && quitar2 || nivel == "ModeOne" && quitar2
            || nivel == "ModeOneDis" && quitar2 || nivel == "TutoOne" && quitar2 || nivel == "TutoOneDis" && quitar2)
        {
            PlayTwo();
            quitar = true;
            quitar2 = false;
        }

    }


    public void PlayOne()
    {
        uno.Play();
        dos.Stop();
    }
    public void PlayTwo()
    {
        uno.Stop();
        dos.Play();
    }

}
