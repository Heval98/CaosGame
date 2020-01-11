using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    public GameObject YO, yo2;
    public Canvas pausa;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(YO.active == false)
            {
                YO.SetActive(true);
            }
            else
            {
                YO.SetActive(false);
            }
            
        }
    }
    public void Salird()
    {
        Application.Quit();
    }
    public void Salirt()
    {
        if (yo2 == true)
        {
            YO.SetActive(false);
        }
    }
    public void botonNo()
    {
        YO.SetActive(false);
        if (!pausa.enabled)
        {
            StartCoroutine(reanudar());
        }
        
    }
    IEnumerator reanudar()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        Time.timeScale = 1;
    }
}
