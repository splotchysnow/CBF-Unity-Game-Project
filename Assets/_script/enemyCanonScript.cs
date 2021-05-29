using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCanonScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject SpecialBullet;
    public GameObject[] Cannons;

    private float timeCount = 0;
    private float bulletTimeControl = 0.01f;

    private AudioSource fullShotAudio;

    private guiInfoScript guiScript;
    public GameObject guiScriptObj;

    private int constant1 = 1000;
    private int constant2 = 10;


    private void Start()
    {
        fullShotAudio = GetComponent<AudioSource>();
        guiScript = guiScriptObj.GetComponent<guiInfoScript>();
    }

    // Update is called once per frame
    void Update()
    {
        randomShots();

        if (guiScript.getSeconds() >= 55)
        {
            //game gets harder;
            constant1 = 10000;
            constant2 = 25;
            bulletTimeControl = 0.03f;
        }
        else if (guiScript.getSeconds() >= 45)
        {
            bulletTimeControl = 0.02f;
        }
        else if (guiScript.getSeconds() >= 0)
        {
            bulletTimeControl = 0.01f;
            constant1 = 1000;
            constant2 = 10;
        }
    }


    //pick a random number and chooses random paths.
    void randomShots()
    {
        int randomValue = Random.Range(0, 10000);

        if (randomValue <= 10000 - constant1) {
            counter();
        }
        else if (randomValue <= 10000 - constant2)
        {
            specialCounter();
        }
        else
        {
            fullShot();
            fullShotAudio.Play();
        }

    }

    void counter() {

        timeCount += bulletTimeControl; //control how often it shoots

        if (timeCount >= 1) {
            timeCount = 0;
            normalShot();   
        }
    }

    void specialCounter()
    {

        timeCount += bulletTimeControl; //control how often it shoots

        if (timeCount >= 1)
        {
            timeCount = 0;
            specialShot();
        }
    }

    void normalShot() {

        int randomValue = Random.Range(0, Cannons.Length);
        //Instantiate(bullet, Cannons[randomValue].transform.position, Cannons[randomValue].transform.rotation);
        GameObject init_Bullet = Instantiate(bullet, Cannons[randomValue].transform.position, Quaternion.identity) as GameObject;
        init_Bullet.transform.parent = GameObject.Find("BulletController").transform;
    }

    // Press K to get the bullet shot mannually.
    void fullShot() {
        for (int i = 0; i < Cannons.Length; i++)
        {
            GameObject init_Bullet = Instantiate(bullet, Cannons[i].transform.position, Quaternion.identity) as GameObject;
            init_Bullet.transform.parent = GameObject.Find("BulletController").transform;
        }
    }

    void specialShot()
    {
        int randomValue = Random.Range(0, Cannons.Length);
        //Instantiate(bullet, Cannons[randomValue].transform.position, Cannons[randomValue].transform.rotation);
        GameObject init_Bullet = Instantiate(SpecialBullet, Cannons[randomValue].transform.position, Quaternion.identity) as GameObject;
        init_Bullet.transform.parent = GameObject.Find("BulletController").transform;
    }
}
