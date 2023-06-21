using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    //Camera

    public GameObject player;
    

    void Update()
    {
        transform.rotation = player.transform.rotation;
        transform.position = player.transform.position;

    }
}

