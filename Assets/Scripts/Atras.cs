using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Atras : MonoBehaviour
{
    public GameObject Primero, Segundo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Primero.SetActive(false);
            Segundo.SetActive(true);
        }
    }
}
