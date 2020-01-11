using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirPausar : MonoBehaviour
{
    public Canvas pausa;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else if(!pausa.enabled)
            {
                Time.timeScale = 1;
            }
            
        }
    }
    public void Salird()
    {
        Application.Quit();
    }
}
