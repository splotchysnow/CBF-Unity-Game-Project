using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchTrigger : MonoBehaviour
{

    public bool switchState = false;
    private void OnTriggerEnter(Collider other)
    { 
        //if projectile enter the trigger, play animation and turn on the trigger.
        if (other.tag == "projectile") 
        {
            //Play animation;
            switchState = true;
        }
    }
}
