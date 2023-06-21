using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 6f;
    public float jumpforce = 6f;
    
    private bool isjumping = true;
    public Vector2 turn;
    public float sensitivity = 1F;

    

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        //movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.AddForce(movement * speed);
        
        
        //Jump
        if (Input.GetButton("Jump") && isjumping == false)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.VelocityChange);
            isjumping = true;
        }
        // dreht sich bei cameradreh
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
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
