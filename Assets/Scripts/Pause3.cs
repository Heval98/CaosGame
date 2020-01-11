using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause3 : MonoBehaviour {

    public bool active;
    public PerderMenu3 condition;
    public AudioSource b1, b2;

    // Use this for initialization
    void Start () {
        active = false;

    //    canvas.enabled = false;
	}
    void Update()
    {
        b1 = GameObject.FindGameObjectWithTag("explo").GetComponent<AudioSource>();
        b2 = GameObject.FindGameObjectWithTag("expa").GetComponent<AudioSource>();
    }

    public void Continuar()
    {
        StartCoroutine(reanudar());
    }

    // Update is called once per frame

    public void Cambiar()
    {

        if (!condition.condition)
        {
            active = !active;
            //      canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
        }
        if (active)
        {
            b1.Pause();
            b2.Pause();
        }
        else
        {
            b1.UnPause();
            b2.UnPause();

        }
    }
    IEnumerator reanudar()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        if (!condition.condition)
        {
            active = !active;
            //      canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
        }
        if (active)
        {
            b1.Pause();
            b2.Pause();
        }
        else
        {
            b1.UnPause();
            b2.UnPause();

        }
    }


}
