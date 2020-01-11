using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirManoTuto : MonoBehaviour
{
    public GameObject Mano;
    public Transform ManoPos; 
    public float tan;
    public float pos1;
    public float pos2;
    public Quaternion angulosfalsos;
    Vector3 angulosreales;
    public float anguloZ;
    public float rad;
    public float angulomov;

    void Start()
    {
        pos1 = 0;
        pos2 = 2;
    }

    void FixedUpdate()
    {
        ManoPos = Mano.GetComponent<Transform>();
        Vector3 direccionCañon = (ManoPos.position - transform.position);
        direccionCañon.Normalize();
        angulomov = Mathf.Atan2(direccionCañon.y, direccionCañon.x) * Mathf.Rad2Deg;
        angulomov = Mathf.Clamp(angulomov, 20, 160);

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
}