using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //Camera

    public Vector2 turn;
    public float sensitivity = .5f;
    public GameObject player;
    //Maus unsichtbar

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    //Camerabewegung bei Mausbewegung

    void Update()
    {
        turn.x += Input.GetAxisRaw("Mouse X") * sensitivity;
        turn.y += Input.GetAxisRaw("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        transform.position = player.transform.position;

    }
}

