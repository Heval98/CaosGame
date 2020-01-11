using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    private bool estadoBolita;
    public bool destruir;
    public Rigidbody2D ballon;
    public float timeCount;
    public bool seguir, seguir2;
    public Transform camera1;
    public float cameraZoom, cameraSpeed;
    public Transform Target;
    public Camera myCamera;

    void Start()
    {
        destruir = false;
        estadoBolita = false;
        timeCount = 0.0f;
        seguir = false;
        seguir2 = false;
    }

    void FixedUpdate()
    {
        if (ballon.constraints == RigidbodyConstraints2D.FreezeAll && estadoBolita)
        {
            Destroy(this);
        }

        timeCount = timeCount + (Time.fixedDeltaTime / 2);

        if (destruir && timeCount >= 0.008f)
        {
            Destroy(gameObject);
        }
        
    }


    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Finish"))
        {
            estadoBolita = true;
        }
        if (col.CompareTag("BarreraCamera"))
        {
            seguir = true;
            seguir2 = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D ball)
    {
        if (ball.CompareTag("Finish"))
        {
            if (gameObject.GetComponent<Rigidbody2D>().constraints != RigidbodyConstraints2D.FreezeAll)
            {
                if (estadoBolita)
                {

                    destruir = true;
                    timeCount = 0.0f;

                }
            }
            else if (ballon.constraints == RigidbodyConstraints2D.FreezeAll)
            {
                if (estadoBolita)
                {
                    Destroy(this);
                }

            }
        }
        
        if (ball.CompareTag("BarreraCamera") && seguir && gameObject.GetComponent<Rigidbody2D>().constraints != RigidbodyConstraints2D.FreezeAll)
        {
            seguir2 = true;
        }


    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            if (estadoBolita)
            {
                destruir = true;
                timeCount = 0.0f;
            }
        }
        if (other.CompareTag("BarreraCamera") && seguir && gameObject.GetComponent<Rigidbody2D>().constraints == RigidbodyConstraints2D.FreezeAll)
        {
            seguir2 = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (ballon.constraints == RigidbodyConstraints2D.FreezeAll)
            Destroy(this);
    }
    void LateUpdate()
    {
        if (seguir2)
        {
            Vector3 newPosition = transform.position;
            newPosition.z = -10;
            camera1.transform.position = Vector3.Lerp(camera1.transform.position, newPosition, Time.deltaTime*10);
            float cameraZoomDiference = cameraZoom - myCamera.orthographicSize;
            myCamera.orthographicSize += cameraZoomDiference * cameraSpeed * Time.deltaTime;
        }
        else
        {
            if (myCamera.transform.position != Target.position)
            {
                Vector3 newPosition = Target.position;
                newPosition.z = -10;
                myCamera.transform.position = Vector3.Lerp(myCamera.transform.position, newPosition, (Time.deltaTime * 10));
                myCamera.orthographicSize = 5;
            }
        }
        
    }

    }