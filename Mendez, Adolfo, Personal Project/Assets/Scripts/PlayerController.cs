using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float zBound = 22;
    private float xBound = 22;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        {
            MovePlayer();
            ConstrainPlayerPosition();
        }
        //Player Movement based on WASD keys
        void MovePlayer()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            playerRb.AddForce(Vector3.forward * speed * verticalInput);
            playerRb.AddForce(Vector3.right * speed * horizontalInput);
        }

        //Prevent the player from leaving the top or bottom of the screen
        void ConstrainPlayerPosition()
        {
            {

            }
            if (transform.position.z < -zBound)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
            }
            if (transform.position.z > zBound)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
            }

            if (transform.position.z < -xBound)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -xBound);
            }
            if (transform.position.z > xBound)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, xBound);
            }
        }


    }
}

