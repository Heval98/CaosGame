using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSize : MonoBehaviour {

    public static IncreaseSize Instance;
    public Rigidbody2D rbBall;
    private bool estado;
    public Transform paddle;
    public Transform paddle2;
    float x = 0.026f;
    float y = 0.026f;
    float z = 0.026f;
    public bool tocar;
    public AudioSource Crecer, Rebote;
    public float tiempo;
    public GameObject Disparo;
    public bool Regresar;

    void Awake()
    {
        estado = false;
        tocar = false;
        Rebote = GameObject.Find("Rebote").GetComponent<AudioSource>();
        Crecer = GameObject.Find("Expande").GetComponent<AudioSource>();
    }
    void Start()
    {

    }

    void FixedUpdate()
    {
        tiempo += Time.fixedDeltaTime;
        if (rbBall.constraints == RigidbodyConstraints2D.FreezeAll && !tocar && rbBall.position.y 
            != paddle.position.y && rbBall.position.x != paddle.position.x)
        { 
            Disparo.SetActive(false);
            x += 0.001f * Time.fixedDeltaTime * 500;
            y += 0.001f * Time.fixedDeltaTime * 500;
            z += 0.001f * Time.fixedDeltaTime * 500;
            transform.localScale = new Vector3(x, y, z);
        }else if (tocar)
        {
            Crecer.Stop();
        }

        if (tocar && tiempo > 3f)
        {
            Destroy(this);
        }
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        this.enabled = true;
        tiempo = 0;
        Rebote.Play();
        tocar = true;
        if (rbBall.constraints == RigidbodyConstraints2D.FreezeAll)
        {
            Rebote.Stop();
            Crecer.Stop();
            Destroy(this);
        }
            
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        tocar = true;
        if (rbBall.constraints == RigidbodyConstraints2D.FreezeAll)
        {
            Destroy(this);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Finish"))
        {
            tiempo = 0;
            if (estado)
            {
                tocar = true;
                if (rbBall.constraints == RigidbodyConstraints2D.FreezeAll)
                {
                    Crecer.Stop();
                    Destroy(this);
                }

            }
        }
        
    }
    

    void OnCollisionExit2D(Collision2D coll)
    {
        tocar = false;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Finish"))
        {
            estado = true;
        }
    }
    void OnDestroy()
    {
        Disparo.SetActive(true);
    }

}