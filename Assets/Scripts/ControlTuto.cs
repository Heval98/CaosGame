using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTuto : MonoBehaviour {

    public float tiempo;
    public float tiempo2;
    public bool control;
    public bool control2;
    public float detener;
    public GameObject ball;
    public GameObject planeta;
    public TutoShooterBehaviour an;
    public GameObject perder, lineaPerder, pantallaperder;

    // Use this for initialization
    void Start () {
        control = false;
        control2 = false;
        tiempo = 0;
        if(tiempo2 >= 5f)
        {
            detener = 2.5f;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
        tiempo += Time.fixedDeltaTime;
        tiempo2 += Time.fixedDeltaTime;
        if (tiempo >= detener)
        {
            control = true;
            if (detener == 2.3f)
            {
                detener = 2.4f;
                planeta.SetActive(true);
            }
        }
        else
        {
            control = false;
        }
        if(ball.transform.localScale.x > 0.2f && ball.transform.localScale.x < 0.3f)
        {
            detener = 2.3f;
            tiempo = 0;
        }
        if(an.anguloZ >= 45f && an.anguloZ <= 45.4f && perder.active == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                tiempo2 = 0;
                control2 = true;
            }
        }    

        if(control2 && tiempo2 >= 0.5f && tiempo2 <= 0.55f)
        {
            Time.timeScale = 0;
            Destroy(this);
        }

        if (pantallaperder.active)
        {
            lineaPerder.GetComponent<SpriteRenderer>().color = new Vector4(1, 0, 0, 1);

        }
        else
        {
            lineaPerder.GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, 1);
        }
        
    }
}
