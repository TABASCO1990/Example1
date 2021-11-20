using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    float gravity = -9.8f;
    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
     
        velocity.y += gravity * Time.deltaTime;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical"); 

        Vector3 movement = transform.right * x + transform.forward * z;
        Vector3 move = new Vector3(speed * movement.x, velocity.y, speed * movement.z);
        controller.Move(move * Time.deltaTime);
    }
}
