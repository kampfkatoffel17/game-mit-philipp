using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kopf : MonoBehaviour
{

    

    public Vector2 turn;
    public float sensitivity = .5f;
    public GameObject player;
    //Maus unsichtbar

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    //Kopfbewegung bei Mausbewegung

    void Update()
    {
        turn.x += Input.GetAxisRaw("Mouse X") * sensitivity;
        turn.y += Input.GetAxisRaw("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);       
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1.24F, player.transform.position.z); ;
        

    }
}
