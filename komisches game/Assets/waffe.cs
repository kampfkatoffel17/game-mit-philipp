using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waffe : MonoBehaviour
{
    public GameObject bulletmodel;
    public Transform bulletspawnpoint;
    public float magazine = 30;
    public float buffer = 0F;
    public bool notreloading = true;
    public float bulletspeed = 30f;
    public float reloadtimeleft;


    // Update is called once per frame
    void Update()
    {
        buffer--;
        reloadtimeleft--;
        if (Input.GetMouseButton(0))
        {
            if ( notreloading  && buffer <= 0 && reloadtimeleft <= 0)
            {

                var bullet = Instantiate(bulletmodel, bulletspawnpoint.position, bulletspawnpoint.rotation);
                
                bullet.GetComponent<Rigidbody>().velocity = bulletspawnpoint.forward * bulletspeed;
                buffer = 120F;
                magazine--;
                

            }
            if(magazine == 0)
            {
                reloadtimeleft = 700F;
                magazine = 30;
                
            }
           
        }
    }
}


