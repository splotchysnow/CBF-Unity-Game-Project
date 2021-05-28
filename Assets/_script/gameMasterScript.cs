using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMasterScript : MonoBehaviour
{
    public GameObject[] switches;

    private bool winBool = false; //set false until win game
    private int count = 0;
    private int storeCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // every frame, check if the switches are turned on.

        for (int i=0; i < switches.Length; i++)
        {
            bool switchCondition = switches[i].GetComponent<switchTrigger>().switchState;

            if (switchCondition)
            {
                count += 1;
            }
        }

        if (count == switches.Length) {

            SceneManager.LoadScene("YouWin");
            
            //win
            
        }
        else
        {
            storeCount = count;
            print(switches.Length);
            count = 0; // reset the check one more time.
        }
        
        
    }

    public int getCount()
    {
        return storeCount;
    }

    public int getSize()
    {
        return switches.Length;
    }
}
