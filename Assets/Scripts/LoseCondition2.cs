using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition2 : MonoBehaviour
{
    private bool estadoBolita;
    public bool destruir;
    public Transform paddle;
    public Transform paddle2;
    public Rigidbody2D ballon;
    public float timeCount;

    void Start()
    {
        destruir = false;
        estadoBolita = false;
        timeCount = 0.0f;
    }

    void FixedUpdate()
    {
        timeCount = timeCount + (Time.fixedDeltaTime / 2);

        if (destruir && timeCount >= 0.01f)
        Destroy(gameObject);
    }


    private void OnTriggerExit2D(Collider2D col)
    {
        estadoBolita = true;
        
    }

    private void OnTriggerEnter2D(Collider2D ball)
    {
        if (gameObject.GetComponent<Rigidbody2D>().constraints != RigidbodyConstraints2D.FreezeAll)
        {
            if (estadoBolita)
            {
                destruir = true;
                timeCount = 0.0f;

            }
        }else if (ballon.constraints == RigidbodyConstraints2D.FreezeAll)
        {
            if (estadoBolita)
            {
                Destroy(this);
            }
            
        }
            

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (estadoBolita)
        {
            destruir = true;
            timeCount = 0.0f;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (ballon.constraints == RigidbodyConstraints2D.FreezeAll && transform.position !=
                paddle.position && transform.position != paddle2.position)
            Destroy(this);
    }
   
}