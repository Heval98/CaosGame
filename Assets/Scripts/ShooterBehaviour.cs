using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterBehaviour : MonoBehaviour
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
    public BallMovement control;
    public bool controlBool;
    public float timeCount;
    public float timeCount2;
    public float timeCount3;
    public GameObject[] balls;

    void Start()
    {
        timeCount = 0.0f;
        timeCount2 = 0.0f;
        pos2 = 2;
        controlBool = true;
    }

    void FixedUpdate()
    {
        balls = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject ball in balls)
        {
            control = ball.GetComponent<BallMovement>();
        }
        controlBool = control.bajarVida;

        if (controlBool)
        {
            timeCount = timeCount + (Time.fixedDeltaTime / 2);
            timeCount2 = timeCount2 + (Time.fixedDeltaTime / 2);
            timeCount3 = timeCount3 + (Time.fixedDeltaTime / 2);
            if (timeCount <= 1.0f && timeCount >= 0f)
            {

                transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount);
                timeCount2 = 0f;

            }
            else if (timeCount > 1.0f)
            {
                transform.rotation = Quaternion.Slerp(to.rotation, from.rotation, timeCount2);
                if (transform.rotation.z == from.rotation.z)
                {
                    
                    timeCount = 0.0f;
                }
            }
                angulosfalsos = transform.rotation;
                angulosreales = angulosfalsos.eulerAngles;
                anguloZ = angulosreales.z;


                    rad = anguloZ * Mathf.Deg2Rad;
                    tan = Mathf.Tan(rad);
                    pos1 = pos2 / tan;


            
        }
    }
}