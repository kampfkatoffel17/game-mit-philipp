using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyturret : MonoBehaviour
{
    public float Leben = 3;
    public Transform spieler;
    public GameObject bulletmodel;
    public Transform bulletspawnpoint;

    public float buffer = 0F;
    public float bulletspeed = 30f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Leben <= 0)
        {
            Destroy(gameObject);
        }
        buffer--;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "bullet")
        {

            Leben--;
        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if(buffer <= 0)
            {
                transform.LookAt(spieler);
                var bullet = Instantiate(bulletmodel, bulletspawnpoint.position, bulletspawnpoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletspawnpoint.forward * bulletspeed;
                buffer = 120F;
            }
            Debug.Log("enemy detected");
           

        }

    }
}
  
   
    
      
        
       
            

              


         
    

