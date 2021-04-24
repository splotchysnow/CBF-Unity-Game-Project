using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteProjectile : MonoBehaviour
{
    public float verticalBoarder;
    public float horizontalBoarder;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z > verticalBoarder || gameObject.transform.position.z < -verticalBoarder) {
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.x > horizontalBoarder || gameObject.transform.position.x < -horizontalBoarder)
        {
            Destroy(gameObject);
        }
    }
}
