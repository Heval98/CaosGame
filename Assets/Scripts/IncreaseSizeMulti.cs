using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSizeMulti : MonoBehaviour {

    public static IncreaseSizeMulti Instance;
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

    void Awake()
    {
        estado = false;
        tocar = false;
        Rebote = GameObject.Find("Rebote").GetComponent<AudioSource>();
        Crecer = GameObject.Find("Expande").GetComponent<AudioSource>();
    }
    void Start()
    {
        estado = false;
        tocar = false;
    }

    void FixedUpdate()
    {
        tiempo += Time.fixedDeltaTime;
        if (rbBall.transform.position.y == paddle.transform.position.y || rbBall.transform.position.y == paddle2.transform.position.y)
        {
            tocar = false;
        }
        if (rbBall.constraints == RigidbodyConstraints2D.FreezeAll && !tocar && rbBall.position.y 
            != paddle.position.y && rbBall.position.x != paddle.position.x)
        {
            Disparo.SetActive(false);
            x += 0.001f * Time.fixedDeltaTime * 500;
            y += 0.001f * Time.fixedDeltaTime * 500;
            z += 0.001f * Time.fixedDeltaTime * 500;
            transform.localScale = new Vector3(x, y, z);
        }
        else if (tocar)
        {
            Crecer.Stop();
        }
        if (tocar && tiempo > 3.0f && rbBall.position.x != paddle.position.x && rbBall.position.x != paddle2.position.x)
        {
            Destroy(this);
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        this.enabled = true;
        tiempo = 0;
        tocar = true;
        if(rbBall.position.x != paddle.position.x && rbBall.position.x != paddle2.position.x)
        {
            Rebote.Play();
        }
        
        if (rbBall.constraints == RigidbodyConstraints2D.FreezeAll && transform.position !=
                paddle.position && transform.position != paddle2.position)
        {
            Rebote.Stop();
            Crecer.Stop();
            Destroy(this);
        }
            
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        tocar = true;
        if (rbBall.constraints == RigidbodyConstraints2D.FreezeAll && (rbBall.position.y < paddle.position.y || rbBall.position.y > paddle2.position.y))
        {
            Destroy(this);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
            tiempo = 0;
            if (estado)
            {

                if (rbBall.constraints == RigidbodyConstraints2D.FreezeAll && transform.position !=
                    paddle.position && transform.position != paddle2.position)
                {
                    Crecer.Stop();
                    Destroy(this);
                }

            }
    }
    

    void OnCollisionExit2D(Collision2D coll)
    {
        tocar = false;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
            tocar = false;
            tiempo = 0;
            estado = true;
        
    }
    void OnDestroy()
    {
        Disparo.SetActive(true);
    }


}
