using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlanetas2 : MonoBehaviour {

    public int contador;
    public Rigidbody2D ball;
    public BallMovement bajarVidaA;
    public bool bajarVidaB;
    public GameObject[] balls;
    public int puntosJuego;
    public bool numerador;
    public PuntosJuego traer;
    public LoseCondition cambio;
    public bool destruira;
    ParticleSystem esf;
    ParticleSystem esf2;
    ParticleSystem esf3;
    ParticleSystem esf4;
    ParticleSystem esf5;
    ParticleSystem esf6;
    public SpriteRenderer spriteR;
    public Sprite[] sprites;
    public int spriteVersion = 0;
    public AudioSource Explocion;

    // Use this for initialization
    void Awake () {
        contador = 3;
        puntosJuego = 0;
        numerador = false;
        Explocion = GameObject.Find("Explocion").GetComponent<AudioSource>();
        esf = GameObject.Find("Onda").GetComponent<ParticleSystem>();
        esf2 = GameObject.Find("Onda2").GetComponent<ParticleSystem>();
        esf3 = GameObject.Find("Onda3").GetComponent<ParticleSystem>();
        esf4 = GameObject.Find("Onda4").GetComponent<ParticleSystem>();
        esf5 = GameObject.Find("Onda5").GetComponent<ParticleSystem>();
        esf6 = GameObject.Find("Onda6").GetComponent<ParticleSystem>();
        sprites = Resources.LoadAll<Sprite>("Sprites/Numbers");
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (contador >= 1)
        {
            spriteVersion = contador - 1;
            spriteR.sprite = sprites[spriteVersion];
        }
        else
        {
            spriteVersion = 3;
        }

        destruira = cambio.destruir;
        balls = GameObject.FindGameObjectsWithTag("GameController");
        foreach (GameObject ball in balls)
        {
            bajarVidaA = ball.GetComponent<BallMovement>();
        }
            bajarVidaB = bajarVidaA.bajarVida;
        if (contador <= 0)
        {
            if (transform.localScale.x < 0.03f)
            {
                esf.transform.position = transform.position;
                esf.Play();
                Vibration.Vibrate(100);
                Explocion.Play();
                Destroy(gameObject);
            }
            else if (transform.localScale.x < 0.16f)
            {
                esf2.transform.position = transform.position;
                esf2.Play();
                Vibration.Vibrate(100);
                Explocion.Play();
                Destroy(gameObject);

            }
            else if (transform.localScale.x < 0.32f)
            {
                esf3.transform.position = transform.position;
                esf3.Play();
                Vibration.Vibrate(100);
                Explocion.Play();
                Destroy(gameObject);
            }
            else if (transform.localScale.x < 0.48f)
            {
                esf4.transform.position = transform.position;
                esf4.Play();
                Vibration.Vibrate(100);
                Explocion.Play();
                Destroy(gameObject);
            }
            else if (transform.localScale.x < 0.64f)
            {
                esf5.transform.position = transform.position;
                esf5.Play();
                Vibration.Vibrate(100);
                Explocion.Play();
                Destroy(gameObject);
            }
            else if (transform.localScale.x < 0.8f)
            {
                esf6.transform.position = transform.position;
                esf6.Play();
                Vibration.Vibrate(100);
                Explocion.Play();
                Destroy(gameObject);
            }
            else 
            {
                esf6.transform.position = transform.position;
                esf6.Play();
                Vibration.Vibrate(100);
                Explocion.Play();
                Destroy(gameObject);
            }
        }
       
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (gameObject.GetComponent<Rigidbody2D>().constraints == RigidbodyConstraints2D.FreezeAll && !bajarVidaB)
        {
            contador--;
        }
    }
    void OnDestroy()
    {
        if(!destruira)
        traer.contadorP += 1;
        traer.ConteoPorTurno++;
    }

}
