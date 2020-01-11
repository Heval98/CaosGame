using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarObjetoDespuesPubli : MonoBehaviour {

    public static ActivarObjetoDespuesPubli Instance;
    public GameObject Disparar;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Activar()
    {
        Disparar.SetActive(true);
    }
}
