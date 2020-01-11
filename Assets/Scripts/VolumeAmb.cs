using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeAmb : MonoBehaviour {

    public static VolumeAmb VolumenJ;
    public Slider slider;
    public AudioSource f1,f2;
    public float volume;
    public string nivel;

    // Use this for initialization
    void Awake()
    {
        
        if (VolumenJ == null)
        {
            VolumenJ = this;
            DontDestroyOnLoad(gameObject);
        }else if (VolumenJ != this)
        {
            Destroy(this);
        }
        
    }

	
	// Update is called once per frame
	void Update () {
        nivel = Application.loadedLevelName;        
        
        
            f1 = GameObject.Find("Ambientacion").GetComponent<AudioSource>();
            f1.volume = volume;
            f2 = GameObject.Find("Fondo2").GetComponent<AudioSource>();
            f2.volume = volume;
        if (nivel == "MainMenu")
        {
            slider = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
            volume = slider.value;
        }
        else
        {

        }

    }
}
