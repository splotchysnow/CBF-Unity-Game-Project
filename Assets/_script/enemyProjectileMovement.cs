using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectileMovement : moveForward
{

    public int zRange = -75;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        disapear();
    }



    //delete offscreen
    void disapear()
    {
        // make the bullet disapear after off the screen for too long.
        if (transform.position.z <= zRange){
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }

        else if (other.tag == "PlayerProjectile")
        {
            Destroy(gameObject);
            Destroy(other);
        }
    }

}
