using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCanonScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject[] Cannons;

    private float timeCount = 0;

    // Update is called once per frame
    void Update()
    {
        counter();
        bugTest();
    }


    void counter() {

        timeCount += 0.02f;

        if (timeCount >= 1) {
            timeCount = 0;
            randomShot();   
        }
    }

    void randomShot() {

        int randomValue = Random.Range(0, Cannons.Length);
        Instantiate(bullet, Cannons[randomValue].transform.position, Cannons[randomValue].transform.rotation);
    }

    // Press K to get the bullet shot mannually.
    void bugTest() {
        if (Input.GetKeyDown(KeyCode.K))
        {
            for (int i = 0; i < Cannons.Length; i++)
            {
                Instantiate(bullet, Cannons[i].transform.position, Cannons[i].transform.rotation);
                print("K have been pressed");
            }

        }
    }

}
