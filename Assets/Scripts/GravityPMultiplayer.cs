using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPMultipayer : MonoBehaviour {

    public float gravityForce;
    public GameObject[] balls;
    public Rigidbody2D rb;
    public int contador;
    int contador2 = 1;
    public float masanum;
    public BallMovement tiempo;
    public float tiempor;
    public float regulador;

    public List<Rigidbody2D> objetos;

	// Use this for initialization
    void Awake()
    {
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        tiempor = tiempo.timeCount;

        balls = GameObject.FindGameObjectsWithTag("GameController"); 
        contador = balls.Length;

                foreach (GameObject ball in balls)
                {
                rb = ball.GetComponent<Rigidbody2D>();
            if (contador > contador2)
            {
                contador2 = contador;
                objetos.Add(balls[contador - 1].GetComponent<Rigidbody2D>());
            }
                }
            foreach (Rigidbody2D objeto in objetos)
            {
                masanum = objeto.mass * 10;
                Vector3 direccionGravedad = ((objeto.transform.position - transform.position).normalized);
                Vector3 direccionObjeto = objeto.transform.up;
                objeto.AddForce(direccionGravedad * gravityForce * masanum);

            }
        
	}
}
