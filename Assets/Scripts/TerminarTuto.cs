using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminarTuto : MonoBehaviour {

    // Use this for initialization
    public void Quitar()
    {
        PlayerPrefs.SetInt("Quitarlo", 1);
    }
    public void Quitar2()
    {
        PlayerPrefs.SetInt("Quitarlo2", 1);
    }
    public void Quitar3()
    {
        PlayerPrefs.SetInt("Quitarlo3", 1);
    }
    public void Quitar4()
    {
        PlayerPrefs.SetInt("Quitarlo4", 1);
    }
    public void Quitar5()
    {
        PlayerPrefs.DeleteAll();
    }
}
