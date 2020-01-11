using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinDEs : MonoBehaviour
{

    public static SinDEs VolumenJ;

    // Use this for initialization
    void Awake()
    {
        if (VolumenJ == null)
        {
            VolumenJ = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (VolumenJ != this)
        {
            Destroy(gameObject);
        }
    }
}
