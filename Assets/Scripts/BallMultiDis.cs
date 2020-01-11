using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMultiDis : MonoBehaviour {


    public Rigidbody2D rbBall;
    public Transform paddle;
    public float poss1;
    public float poss2;
    public float poss3;
    public float poss4;
    Vector2 velocidadInicial;
    Vector2 velocidadInicial2;
    public GameObject newBall;
    public float timeCount;
    public float velocity;
    public GameObject clone;
    public Transform pausa;
    public Vector3 mousePos;
    public Vector3 objPos;
    public GameObject objetoPausar;
    public Vector3 objetoPausarV;
    public bool bajarVida;
    public bool bajarVida2;
    public bool bajarVida3;
    public int spriteVersion = 0;
    public SpriteRenderer spriteR, spriteP;
    public Sprite[] sprites;
    public Transform paddle2;
    public bool Bandera;
    public SpriteRenderer numero;
    public AudioSource Crecer, Disparar;
    public GameObject Disparo;

    void Awake()
    {

    }

    // Use this for initialization
    void Start () {
        Disparar = GameObject.Find("Disparo").GetComponent<AudioSource>();
        Crecer = GameObject.Find("Expande").GetComponent<AudioSource>();
        rbBall.GetComponent<Rigidbody2D>();
        spriteR = gameObject.GetComponent<SpriteRenderer>();  
        sprites = Resources.LoadAll<Sprite>("Sprites/Bullets");
        spriteVersion += 1;
        bajarVida3 = true;
        
    }

    // Update is called once per frame
    void Update() {
        if(rbBall.position.x == paddle.position.x && rbBall.position.y == paddle.position.y)
        {
            Bandera = true;
        }else if (rbBall.position.x == paddle2.position.x && rbBall.position.y == paddle2.position.y)
        {
            Bandera = false;
        }
        if(transform.position == paddle.position)
        {
            bajarVida = true;
        }
        else 
        {
            bajarVida = false;
        }

        if (transform.position == paddle2.position)
        {
            bajarVida2 = true;
        }
        else
        {
            bajarVida2 = false;
        }



        spriteP = GetComponent<SpriteRenderer>();

        if (spriteVersion >= 3)
        {
            spriteVersion = 0;
        }

        spriteR.sprite = sprites[spriteVersion]; 

        timeCount = timeCount + (Time.fixedDeltaTime);
        poss1 = paddle.GetComponent<Movimientoapuntar1>().pos1;
        poss2 = paddle.GetComponent<Movimientoapuntar1>().pos2;
        poss3 = paddle2.GetComponent<Movimientoapuntar2>().pos1;
        poss4 = -2;
        objetoPausarV = objetoPausar.transform.position;

        velocidadInicial = new Vector2(poss1, poss2);
        velocidadInicial2 = new Vector2(poss3, poss4);
        velocidadInicial.Normalize();
        velocidadInicial2.Normalize();

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        objPos = Camera.main.ScreenToWorldPoint(objetoPausarV);


            if (Input.GetMouseButtonUp(0) && Time.timeScale == 1 && Disparo.active)
            {
                if (mousePos.x > (objPos.x - 0.21f) && mousePos.y < (objPos.y + 0.8f))
                {
                }
                else if (transform.position.y <= paddle.position.y)
                {
                    Disparar.Play();
                    rbBall.constraints = RigidbodyConstraints2D.None;
                    rbBall.constraints = RigidbodyConstraints2D.FreezeRotation;
                    bajarVida3 = false;
                    rbBall.velocity = velocidadInicial * 28;
                    timeCount = 0f;
                }
            }

            //    Instantiate(newBall, paddle.position, Quaternion.identity);

            

            if (Input.GetMouseButtonUp(0) && Time.timeScale == 1 && Disparo.active)
            {
                if (mousePos.x > (objPos.x - 0.21f) && mousePos.y < (objPos.y + 0.8f))
                {
                }
                else if (transform.position.y >= paddle2.position.y)
                {
                    Disparar.Play();
                    rbBall.constraints = RigidbodyConstraints2D.None;
                    rbBall.constraints = RigidbodyConstraints2D.FreezeRotation;
                    bajarVida3 = false;
                    rbBall.velocity = velocidadInicial2 * 28;
                    timeCount = 0f;
                }
            }
        
        else if (timeCount >= 3.0f)
        {
            timeCount = 0f;
            
            if (rbBall.position.y != paddle.position.y && rbBall.position.y != paddle2.position.y)
            {
                Crecer.Play();
                // && rbBall2.position.y != paddle2.position.y
                rbBall.constraints = RigidbodyConstraints2D.FreezeAll;
                if (Bandera)
                {
                    clone = Instantiate(newBall, paddle2.position, Quaternion.identity);
                    bajarVida3 = true;
                    Destroy(this);
                }
                else
                {
                    clone = Instantiate(newBall, paddle.position, Quaternion.identity);
                    bajarVida3 = true;
                    Destroy(this);
                    
                }


            }
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Vibration.Vibrate(55);

    }

}