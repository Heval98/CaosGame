using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTrigger2 : MonoBehaviour {

    public GameObject[] balls; 
    public BallMultiDis Lado;
    public bool lado1;
    public BoxCollider2D arriba;
    public BoxCollider2D abajo;

    // Use this for initialization
    void Start () {
        lado1 = false;
	}
	
	// Update is called once per frame
	void Update () {
        balls = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject ball in balls)
        {
            Lado = ball.GetComponent<BallMultiDis>();
        }
        lado1 = Lado.Bandera;

        if (lado1)
        {
            arriba.isTrigger = false;
            abajo.isTrigger = true;
        }
        else
        {
            arriba.isTrigger = true;
            abajo.isTrigger = false;
        }
	}
}
