using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scape : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
