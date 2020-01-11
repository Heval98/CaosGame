using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitatTuto : MonoBehaviour {

    public int s;
    public GameObject Esp1, Esp2, Ing1, Ing2;

    // Use this for initialization
    void Awake()
    {
        s = PlayerPrefs.GetInt("Quitarlo");
    }

    void Start () {
        if (s == 1)
        {
            Esp1.SetActive(false);
            Ing1.SetActive(false);
            Esp2.SetActive(true);
            Ing2.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (s == 1)
        {
            Esp1.SetActive(false);
            Ing1.SetActive(false);
            Esp2.SetActive(true);
            Ing2.SetActive(true);
        }


    }

}
