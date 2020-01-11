using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    public bool active;
    public PerderMenu condition;
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

        // Update is called once per frame

        public void Cambiar ()
    {
        StartCoroutine(reanudar());
        //if (!condition.condition)
        //{
        //    active = !active;
        //    //      canvas.enabled = active;
        //    Time.timeScale = (active) ? 0 : 1f;
        //}
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

    public void Unpausee()
    {
        Time.timeScale = 1;
    }

    IEnumerator reanudar()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        if (!condition.condition)
        {
            active = !active;
            //      canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
        }
    }

}
