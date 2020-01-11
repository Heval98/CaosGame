using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTuto2 : MonoBehaviour
{

    public float tiempo;
    public bool control;

    // Use this for initialization
    void Start()
    {
        control = false;
    }

    // Update is called once per frame
    public void Tutorial()
    {
        Time.timeScale = 1;
        tiempo = 0;
        control = true;
    }
    void FixedUpdate()
    {
        tiempo += Time.fixedDeltaTime;
        if(tiempo >= 0.3f && control)
        {
            Time.timeScale = 0;
        }
    }
    }