using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectileMovement : moveForward
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        disapear();
    }

    //delete offscreen
    void disapear()
    {
        // make the bullet disapear after off the screen for too long.
        if (transform.position.z <= -150){
            Destroy(gameObject);
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player") {
    //        Destroy(other); //later call the player object and decrease health;
    //        print("hit");
    //        print(other);
    //    }
    //}

}
