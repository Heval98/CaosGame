using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgrCollider : MonoBehaviour {

    public float Ancho;
    public float Alto;
    public float Relacion;
    public GameObject pared;
    public GameObject pared2;

    // Use this for initialization
    void Awake() {
        Ancho = Screen.width;
        Alto = Screen.height;
        Relacion = Alto / Ancho;
        Relacion *= 9;
	}

    // Update is called once per frame
    void Update() {
        if(Relacion >= 13.4f && Relacion <= 14)
        {
            pared.transform.position = new Vector3(3.79f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.79f, pared2.transform.position.y, pared2.transform.position.z);
        }else if (Relacion >= 14.000001 && Relacion <= 14.3999)
        {
            pared.transform.position = new Vector3(3.63f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.63f, pared2.transform.position.y, pared2.transform.position.z);
        }
        else if (Relacion >= 14.4f && Relacion <= 14.7999)
        {
            pared.transform.position = new Vector3(3.6f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.6f, pared2.transform.position.y, pared2.transform.position.z);
        }
        else if (Relacion >= 14.8f && Relacion <= 15)
        {
            pared.transform.position = new Vector3(3.5f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.5f, pared2.transform.position.y, pared2.transform.position.z);
        }
        else if (Relacion >= 15.0001f && Relacion <= 15.3999)
        {
            pared.transform.position = new Vector3(3.44f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.44f, pared2.transform.position.y, pared2.transform.position.z);
        }
        else if (Relacion >= 15.4f && Relacion <= 15.7999)
        {
            pared.transform.position = new Vector3(3.4f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.4f, pared2.transform.position.y, pared2.transform.position.z);
        }
        else if (Relacion >= 15.8f && Relacion <= 16.399)
        {
            pared.transform.position = new Vector3(3.3f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.3f, pared2.transform.position.y, pared2.transform.position.z);
        }
        else if (Relacion >= 16.4f && Relacion <= 16.7999)
        {
            pared.transform.position = new Vector3(3.2f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.2f, pared2.transform.position.y, pared2.transform.position.z);
        }
        else if (Relacion >= 17.8f && Relacion <= 17.399)
        {
            pared.transform.position = new Vector3(3.1f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.1f, pared2.transform.position.y, pared2.transform.position.z);
        }
        else if (Relacion >= 17.4f && Relacion <= 17.7999)
        {
            pared.transform.position = new Vector3(3.05f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.05f, pared2.transform.position.y, pared2.transform.position.z);
        }
        else if (Relacion >= 17.8f)
        {
            pared.transform.position = new Vector3(3f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3f, pared2.transform.position.y, pared2.transform.position.z);
        }
        else
        {
            pared.transform.position = new Vector3(3.81f, pared.transform.position.y, pared.transform.position.z);
            pared2.transform.position = new Vector3(-3.81f, pared2.transform.position.y, pared2.transform.position.z);
        }

    }
}
