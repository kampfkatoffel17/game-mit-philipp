using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 6f;
    public float jumpforce = 6f;
    public Vector3 move;

    private bool isjumping = true;

    //Variablen für drehen
    public Vector2 turn;
    public float sensitivity = .5f;

    //andere Sachen
    public float jumppadforce = 10F;
    public bool jumppad = false;

    //
    public float Leben = 5;
    public GameObject Kopf;
    public GameObject Grabstein;




    public Rigidbody rb;
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        //movement
        move.x = Input.GetAxis("Horizontal") * speed;
        move.y = Input.GetAxis("Vertical") * speed;

        transform.Translate(move.x, 0, move.y);



        //Jump
        if (Input.GetButton("Jump") && isjumping == false && jumppad == false)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isjumping = true;
        }

        turn.x += Input.GetAxisRaw("Mouse X") * sensitivity;
        transform.localRotation = Quaternion.Euler(0, turn.x, 0);

        //jumppad      
        if (Input.GetButton("Jump") && isjumping == false && jumppad == true)
        {
            rb.AddForce(Vector3.up * jumppadforce, ForceMode.Impulse);
            isjumping = true;
        }

        //Leben
        if (Leben == 0)
        {
            death();

        }


    }
    //collisionsdetection
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boden")
        {
            jumppad = false;
            isjumping = false;
        }

        if (collision.gameObject.tag == "jump pad")
        {
            jumppad = true;
            isjumping = false;

        }

        if (collision.gameObject.tag == "trap")
        {
            Leben -= 1;           
            isjumping = false;
            jumppad = false;
        }
        if (collision.gameObject.tag == "turret bullet")
        {

            Leben -= 1;
        }




    }
    
    //Tod
    void death ()
    {
        Debug.Log("reingeschissen");
        Destroy(gameObject);
            Destroy(Kopf);
       
    }

   
}
  
   



