using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 6f;
    public float jumpforce = 6f;
    
    private bool onfloor = true;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.AddForce(movement * speed);
    }
}
