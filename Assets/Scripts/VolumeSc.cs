using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSc : MonoBehaviour {

    public static VolumeSc VolumenJ;
    public Slider slider;
    public Slider slideram;
    public AudioSource f1,f2,f3,f4,f5;
    public AudioSource Ambiente, boton;
    public float volume;
    public float volumeam;
    public string nivel;

    // Use this for initialization
    void Awake()
    {
        if(VolumenJ == null)
        {
            VolumenJ = this;
            DontDestroyOnLoad(gameObject);
        }else if (VolumenJ != this)
        {
            Destroy(gameObject);
        }
        
    }

	
	// Update is called once per frame
	void Update () {
        nivel = Application.loadedLevelName;
        

            

        if (nivel == "MainMenu")
        {
            slider = GameObject.FindGameObjectWithTag("Wall").GetComponent<Slider>();
            volume = slider.value;
        }

            boton = GameObject.Find("BotonSound").GetComponent<AudioSource>();
            boton.volume = volume;
            f1 = GameObject.Find("Disparo").GetComponent<AudioSource>();
            f1.volume = volume;
            f2 = GameObject.Find("Explocion").GetComponent<AudioSource>();
            f2.volume = volume;
            f3 = GameObject.Find("Expande").GetComponent<AudioSource>();
            f3.volume = volume;
            f4 = GameObject.Find("Rebote").GetComponent<AudioSource>();
            f4.volume = volume;
            f5 = GameObject.Find("Perder").GetComponent<AudioSource>();
            f5.volume = volume;
        



    }
}
