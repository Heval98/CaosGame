using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementDis : MonoBehaviour {


    public Pause cuerpo;
    public Rigidbody2D rbBall;
    public Transform paddle;
    public float poss1;
    public float poss2;
    Vector2 velocidadInicial;
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
    public int spriteVersion = 0;
    public SpriteRenderer spriteR, spriteP;
    public Sprite[] sprites;
    public AudioSource Crecer, Disparar;
    public GameObject Disparo;

    // Use this for initialization
    void Start () {
        Disparar = GameObject.Find("Disparo").GetComponent<AudioSource>();
        Crecer = GameObject.Find("Expande").GetComponent<AudioSource>();
        rbBall.GetComponent<Rigidbody2D>();
        rbBall.constraints = RigidbodyConstraints2D.None;
        rbBall.constraints = RigidbodyConstraints2D.FreezeRotation;
        bajarVida = true;
        spriteR = gameObject.GetComponent<SpriteRenderer>();  
        sprites = Resources.LoadAll<Sprite>("Sprites/Bullets");
        spriteVersion += 1;

    }

    // Update is called once per frame
    void Update() {

        spriteP = GetComponent<SpriteRenderer>();

        if (spriteVersion >= 3)
        {
            spriteVersion = 0;
        }

        spriteR.sprite = sprites[spriteVersion]; 

        timeCount = timeCount + (Time.fixedDeltaTime);
        poss1 = paddle.GetComponent<Movimientoapuntar>().pos1;
        poss2 = paddle.GetComponent<Movimientoapuntar>().pos2;
        objetoPausarV = objetoPausar.transform.position;

        velocidadInicial = new Vector2(poss1, poss2);
        velocidadInicial.Normalize();

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        objPos = Camera.main.ScreenToWorldPoint(objetoPausarV);

  //      if (transform.position.y == paddle.position.y)
  //      {
             if (Input.GetMouseButtonUp(0) && Time.timeScale == 1)
            {
                
                if (mousePos.x > (objPos.x - 0.21f) && mousePos.y < (objPos.y + 0.8f))
                {
                }
                else if (transform.position.y == paddle.position.y && Disparo.active)
                {
                    Disparar.Play();
                    //    rbBall.constraints = RigidbodyConstraints2D.None;
                    //    rbBall.constraints = RigidbodyConstraints2D.FreezeRotation;
                    bajarVida = false;
                    rbBall.velocity = velocidadInicial * 28;
                    timeCount = 0f;
                }

            }

             /*
            if (Input.GetMouseButtonUp(0))
            {

                if (mousePos.x > (objPos.x - 0.21f) && mousePos.y < (objPos.y + 0.8f))
                {
                }
                else
                {
                    Disparar.Play();
                    //    rbBall.constraints = RigidbodyConstraints2D.None;
                    //    rbBall.constraints = RigidbodyConstraints2D.FreezeRotation;
                    bajarVida = false;
                    rbBall.velocity = velocidadInicial * 28;
                    timeCount = 0f;
                }

            }
            */
            //    Instantiate(newBall, paddle.position, Quaternion.identity);


     //   }
        else if (timeCount >= 3.0f)
        {
            timeCount = 0f;
            

            if (rbBall.position.y != paddle.position.y)
            {
                Crecer.Play();

                rbBall.constraints = RigidbodyConstraints2D.FreezeAll;
                clone = Instantiate(newBall, paddle.position, Quaternion.identity);
                bajarVida = true;
                
                Destroy(this);
                
            }
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Vibration.Vibrate(55);

    }


}