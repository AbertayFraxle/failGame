using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public CharacterController controller;
    public float spd = 12f;
    public float grv = -9.8f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDis = 0.4f;  //ground distance you twat
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDis, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move*spd * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * grv * -2f);
        }

        velocity.y += grv * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
