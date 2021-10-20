/*
 * Name: Brianna Scott
 * Date: August 6, 2021
 * Purpose: The purpose of this code is to enable the first person camera, giving Alice the ability to see her
 * surroundings.
 */

//preprocessor directives
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MouseLook class
public class MouseLook : MonoBehaviour
{
    //declare float variable mouse sensitivity and set it equal to 100f
    public float mouseSensitivity = 100f;
    //declare float value xRotation
    float xRotation = 0f;
    //declare transform variable playerBody , aka, the cylinder until alice is developed
    public Transform playerBody;

    //start function
    void Start()
    {
        
    }

    //update function
    void Update()
    {
        //declare float value mouseX to equal GetAxis(), then multiply
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //declare float variable mouseY to equal GetAxis(), then multiply
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //enable the player to look around using the mouseX movement
        playerBody.Rotate(Vector3.up * mouseX);
        //decreases xRotation based on mouseY; increasing it will cause it to flip
        xRotation -= mouseY;
        //enables the clamping; clamping will prevent the camera from going too far back; only 180 degrees
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //Sets the rotation 
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
