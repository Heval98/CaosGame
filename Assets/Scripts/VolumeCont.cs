using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeCont : MonoBehaviour {

    public Slider slider;
    public VolumeSc volume;
    public float flotante;

    // Use this for initialization
    void Awake()
    {
        volume = GameObject.FindGameObjectWithTag("Mensaje").GetComponent<VolumeSc>();
        flotante = volume.volume;
        slider.value = flotante;

    }


    }
