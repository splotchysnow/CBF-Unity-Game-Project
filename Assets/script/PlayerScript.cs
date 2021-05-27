using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{



    public float horizontalInput;
    public float verticalInput;
    public float speed;
    public GameObject projectilePrefab;
    public float rotateSpeed;

    public GameObject healthGUI;

    public int health = 10;

    // Update is called once per framessss
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space has been pressed");
            //space key should shoot something forward;
        }

        if (Input.GetKeyDown(KeyCode.J)) {
            // Produce projectile and shoot foward;
            Instantiate(projectilePrefab, gameObject.transform.position, gameObject.transform.rotation);
        }

        //Rotation movement:
        if (Input.GetKey(KeyCode.Q)) {
            //rotate left direction
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            //Rotate Right direction
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }

        //movement from left to right.
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        gameOver();


    }

    void hit() {
        health -= 1; //health goes down.
        // update the health bar:
        healthGUI.GetComponent<guiInfoScript>().takeAwayLastHeart();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyProjectile")
        {
            hit();
            Destroy(other);
        }
        print(other.tag);
    }


    void gameOver() {
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
