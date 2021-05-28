using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specialEnemyProjectile : enemyProjectileMovement
{
    public float movespeed = 5f;
    public float frequency = 0.25f;
    public float magnitude = 15f;

    Vector3 pos;


    private void Start()
    {
        pos = transform.position;
        
    }

    private void Update()
    {
        pos -= transform.forward * Time.deltaTime * movespeed;
        transform.position = pos + transform.right * Mathf.Sin(Time.time * frequency) * magnitude;
    }

}
