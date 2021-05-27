using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiInfoScript : MonoBehaviour
{
    public GameObject Hearts;
    public GameObject Player;
    public GameObject spawner;

    private Vector3 offset = new Vector3(30, 0, 0);
    private int counter = 0;
    private List<GameObject> HeartLists = new List<GameObject>();

    private void Start()
    {
        //Initiate three heart GUI on top left when game starts
        //Instantiate(Hearts, parents.transform.position, parents.transform.rotation);

        //GameObject Heart = Instantiate(Hearts, spawner.transform.position, Quaternion.identity) as GameObject;
        //Heart.transform.parent = GameObject.Find("Canvas").transform;

        //GameObject Heart2 = Instantiate(Hearts, spawner.transform.position + offset, Quaternion.identity) as GameObject;
        //Heart2.transform.parent = GameObject.Find("Canvas").transform;

        //GameObject Heart3 = Instantiate(Hearts, spawner.transform.position + 2 * offset, Quaternion.identity) as GameObject;
        //Heart3.transform.parent = GameObject.Find("Canvas").transform;


        HeartLists.Add(instatiateHeart());
        HeartLists.Add(instatiateHeart());
        HeartLists.Add(instatiateHeart());

        takeAwayLastHeart();
    }

    //if item pick up heart+ is called, call this function and add a heart on the GUI
    private GameObject instatiateHeart() {
        GameObject Heart = Instantiate(Hearts, spawner.transform.position + counter * offset, Quaternion.identity) as GameObject;
        Heart.transform.parent = GameObject.Find("Canvas").transform;
        counter += 1;

        return Heart;
    }

    //Removes the last heart on the top.
    private void takeAwayLastHeart()
    {
        Destroy(HeartLists[HeartLists.Count-1]);
    }

}
