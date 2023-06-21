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

        transform.Translate(move.x, 0, move.y );
        
        
        
        //Jump
        if (Input.GetButton("Jump") && isjumping == false)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isjumping = true;
        }

        turn.x += Input.GetAxisRaw("Mouse X") * sensitivity;
        transform.localRotation = Quaternion.Euler(0, turn.x, 0);

    }
    //collisionsdetection
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Boden")
        {

            isjumping = false;
        }
       

    }
    
  
   


}
