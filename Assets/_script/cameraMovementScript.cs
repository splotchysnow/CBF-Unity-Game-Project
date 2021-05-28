using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovementScript : MonoBehaviour
{

    public Vector3 offset;
    public GameObject player;

    private bool cCheck = false; // Check if c is pressed
    public Vector3 rotateVector1; // the vector that rotate to the side view:
    public Vector3 cOffset; // the vector for moving after the camera is moved.
    public Vector3 rotateVector2; // top down view vector;

    private void Start()
    {
        gameObject.transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        //normalCameraAngle();
        changeCameraAngle();
    }

    void changeCameraAngle()
    {
        // check if c is being pressed
        if (Input.GetKeyDown(KeyCode.C) & cCheck == false)
        {
            gameObject.transform.Rotate(rotateVector1); //if so, rotate the camera angle to 0 (This works)
            gameObject.transform.position = player.transform.position + cOffset; //the current position + the offset camera
            cCheck = true;
        }
        else if (Input.GetKeyDown(KeyCode.C) & cCheck == true)
        {
            gameObject.transform.Rotate(rotateVector2); //if so, rotate the camera angle to 90 (This works)
            gameObject.transform.position = player.transform.position + offset; //updates the position of the camera to player + offset //the current position + the offset camera
            cCheck = false;
        }

    }


    void normalCameraAngle() {
        //this changes the camera back to the original camera angle;
        gameObject.transform.position = player.transform.position + offset; //updates the position of the camera to player + offset

    }

}
