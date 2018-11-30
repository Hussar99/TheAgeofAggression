using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Extra using statement to allow us to use the scene managament functions
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float speed = 10;
    public float jumpSpeed = 20;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public string jumpButton = "Jump";

 


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Get axis input from Unity
        float leftRight = Input.GetAxis(horizontalAxis);

        // Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, 0);

        // Make direction vector length 1
        direction = direction.normalized;

        // Calculate the velocity
        Vector2 velocity = direction * speed;
        velocity.y = physicsBody.velocity.y;

        // Give the velocity to the rigid body
        physicsBody.velocity = velocity;


        // Jumpoing

        bool jumpButtonPressed = Input.GetButtonDown(jumpButton);
        if (jumpButtonPressed == true)
        {
            // We have pressed jump, so we should set our upward velocity to jumpSpeed
            velocity.y = jumpSpeed;

            // Give the velocity to rigidbody
            physicsBody.velocity = velocity;


        }

    }

    // Our own function for handling player death
    public void Kill()
    {
        // Reset the current level to reset from the beggining.

        // First, ask unity what the current level is
        Scene currentLevel = SceneManager.GetActiveScene();

        // Second, tell unity to load the current level again by passing the build index of our level
        SceneManager.LoadScene(currentLevel.buildIndex);

    }


}
