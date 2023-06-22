using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kugel : MonoBehaviour
{
    // Start is called before the first frame update
    public float Leben = 3F;
    private void Awake()
    {
        Destroy(gameObject, Leben);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
