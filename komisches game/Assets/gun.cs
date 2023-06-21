using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject bulletobjekt;
    public Transform buletspawn;
    public float bulletspeed = 10F;
    

    

    // Update is called once per frame
    void Update()
    {
       if ( Input.GetKeyDown("e"))
        {
            var bullet = Instantiate(bulletobjekt, buletspawn.position, buletspawn.rotation);
            bullet.GetComponent<Rigidbody>().velocity = buletspawn.forward * bulletspeed;

        }
       
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1.24F, player.transform.position.z); 

    }
}
