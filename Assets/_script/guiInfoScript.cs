using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guiInfoScript : MonoBehaviour
{
    public GameObject Hearts;
    public GameObject Player;
    public GameObject spawner;

    private Vector3 offset = new Vector3(30, 0, 0);
    private int counter = 0;
    private List<GameObject> HeartLists = new List<GameObject>();

    private int health_; // copy of the player script's heatlh variable

    public Text switchCount; //represent the switches left in game.
    public GameObject Camera; //store the camera in here
    private gameMasterScript cameraScript; //get the switch count.
    public int switchIntCount; // the value needs to store in.


    //timer;
    private float point = 0;
    public Text pointText;
    private int minCount = 0;



    private void Start()
    {

        // get the component from the script player:
        PlayerScript playerScript = Player.GetComponent<PlayerScript>();
        health_ = playerScript.health;

        


        //set up player's health GUI
        for (int i = 0; i < health_; i++)
        {
            HeartLists.Add(instatiateHeart());
        }


        cameraScript = Camera.GetComponent<gameMasterScript>();
        //takeAwayLastHeart();
        //takeAwayLastHeart();
        //takeAwayLastHeart();

        //for (int i = 0; i < HeartLists.Count - 1; i++)
        //{
        //    print(HeartLists[i]);
        //}

        //Initiate three heart GUI on top left when game starts
        //Instantiate(Hearts, parents.transform.position, parents.transform.rotation);

        //GameObject Heart = Instantiate(Hearts, spawner.transform.position, Quaternion.identity) as GameObject;
        //Heart.transform.parent = GameObject.Find("Canvas").transform;

        //GameObject Heart2 = Instantiate(Hearts, spawner.transform.position + offset, Quaternion.identity) as GameObject;
        //Heart2.transform.parent = GameObject.Find("Canvas").transform;

        //GameObject Heart3 = Instantiate(Hearts, spawner.transform.position + 2 * offset, Quaternion.identity) as GameObject;
        //Heart3.transform.parent = GameObject.Find("Canvas").transform;
        updateText();


    }

    private void LateUpdate()
    {
        updateText();
        
        point += Time.deltaTime;

        pointText.text = "Time survived: " + minCount + " min and " + getSeconds() + " seconds";



    }

    public float getSeconds()
    {
        if (point == 60)
        {
            minCount += 1;
        }

        return Mathf.FloorToInt(point % 60);
    }


    private void updateText()
    {
        switchIntCount = cameraScript.getCount();
        switchCount.text = "Switch Count: " + switchIntCount + "/" + cameraScript.getSize() ;
    }


    //if item pick up heart+ is called, call this function and add a heart on the GUI
    public GameObject instatiateHeart() {
        GameObject Heart = Instantiate(Hearts, spawner.transform.position + counter * offset, Quaternion.identity) as GameObject;
        Heart.transform.parent = GameObject.Find("Canvas").transform;
        counter += 1;
        return Heart;
    }

    //Removes the last heart on the top.
    public void takeAwayLastHeart()
    {
        Destroy(HeartLists[HeartLists.Count - 1]);
        HeartLists.RemoveAt(HeartLists.Count - 1);
        //print(HeartLists.Count);
    }

}
