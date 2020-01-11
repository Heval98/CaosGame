using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeCont2 : MonoBehaviour {

    public Slider slider2;
    public VolumeAmb volume2;
    public float flotante2;

    // Use this for initialization
    void Awake()
    {
        volume2 = GameObject.FindGameObjectWithTag("Wall2").GetComponent<VolumeAmb>();
        flotante2 = volume2.volume;
        slider2.value = flotante2;

    }


    }
