using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovingMenu : MonoBehaviour
{
    public int speed = 10;
    private bool turned = false;

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x >= -50 )
        {
            if (transform.position.x >= 46)
            {
                speed = -speed;
                turned = true;
            }
            if (transform.position.x <= 0 && turned)
            {
                speed = 0;
            }
            
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            
            
        }


    }
}
