using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchTrigger : MonoBehaviour
{


    Animator anim;
    AudioSource audio;

    private void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    public bool switchState = false;
    private void OnTriggerEnter(Collider other)
    { 
        //if projectile enter the trigger, play animation and turn on the trigger.
        if (other.tag == "PlayerProjectile") 
        {
            //Play animation;
            switchState = true;
            anim.SetTrigger("switchTrigger");
            audio.Play();

        }
    }



    
}
