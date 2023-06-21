using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawpint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject waffe;
    void Start()
    {
        transform.position = waffe.transform.position;
        transform.rotation = waffe.transform.rotation;
    }

}
