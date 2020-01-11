using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientoapuntar : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public float tan;
    public float pos1;
    public float pos2;
    public Quaternion angulosfalsos;
    Vector3 angulosreales;
    public float anguloZ;
    public float rad;
    public BallMovementDis control;
    public bool controlBool;
    public float timeCount;
    public float timeCount2;
    public float timeCount3;
    public GameObject[] balls;
    public float angulomov;
    public GameObject laser;

    void Start()
    {
        timeCount = 0.0f;
        timeCount2 = 0.0f;
        pos1 = 0;
        pos2 = 2;
        controlBool = true;
    }

    void FixedUpdate()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direccionCañon = (mousePos - transform.position);
        direccionCañon.Normalize();
        angulomov = Mathf.Atan2(direccionCañon.y, direccionCañon.x) * Mathf.Rad2Deg;
        angulomov = Mathf.Clamp(angulomov, 20, 160);
        balls = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject ball in balls)
        {
            control = ball.GetComponent<BallMovementDis>();
        }
        controlBool = control.bajarVida;

        if (controlBool)
        {
            laser.SetActive(true);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, angulomov);
                angulosfalsos = transform.rotation;
                angulosreales = angulosfalsos.eulerAngles;
                anguloZ = angulosreales.z;

                if (anguloZ == 90.0f)
                {
                    pos1 = 0;
                    pos2 = 2;

                }
                else
                {
                    rad = anguloZ * Mathf.Deg2Rad;
                    tan = Mathf.Tan(rad);
                    pos1 = pos2 / tan;
                }


        }
        else
        {
            laser.SetActive(false);
        }
    }
}