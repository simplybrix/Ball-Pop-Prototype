/*
 * Name: Brianna Scott
 * Date: August 6, 2021
 * Purpose: The purpose of this code is to enable the player's ability to move; Alice should be able to move thoughout
 * the room by jumping, running, or walking.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //create a reference to the character controller
    public CharacterController controller;

    //declare public float variable speed and set it to 12f
    public float speed = 12f;
    //declare public float variable named gravity and set equal to -9.81f
    public float gravity = -9.81f;

    //declare public transform object named ground Check
    public Transform groundCheck;
    //delcare public float variable groundDistance and set it to 0.4
    public float groundDistance = 0.4f;
    //declare layermask named groundMask
    public LayerMask groundMask;

    //creation of velocity or giving alive gravity to fall when she jumps
    Vector3 velocity;
    //declare bool function isGrounded
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        //performs a ground check using physics that creats a sphere
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //if isGrounded and the velocity of the y axis is less than 0
        if (isGrounded && velocity.y < 0)
        {
            //force the player to fall to the ground
            velocity.y = -2f;
        }

        //Declare float value x that equals GetAxis
        float x = Input.GetAxis("Horizontal");
        //Declare float value z that equals GetAxis
        float z = Input.GetAxis("Vertical");

        //creates a new vector called move that moves along the x and z axis
        Vector3 move = transform.right * x + transform.forward * z;
        //give the controller the option to move
        controller.Move(move * speed * Time.deltaTime);

        //addition of sprinting/running components
        if (Input.GetKey("left shift") && isGrounded)
        {
            //if key pressed, run
            speed = 20f;
        }
        //else statement
        else
        {
            //else remain at current speed
            speed = 12f;
        }

        //basic physics
        velocity.y += gravity * Time.deltaTime;
        //basic physics
        controller.Move(velocity * Time.deltaTime);
    }
}
