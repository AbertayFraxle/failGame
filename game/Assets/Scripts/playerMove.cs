using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Transform cam;
    public CharacterController controller;

    public float spd = 12f;
    public float grv = -9.8f;
    public float jumpHeight = 3f;

    public float turnSmooth = 0.1f;
    float turnSmoothVelocity;

    public Transform groundCheck;
    public float groundDis = 0.4f;  //ground distance you twat
    public LayerMask groundMask;

    [SerializeField]
    public Animator animator;

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
        // Update is called once per frame
        void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDis, groundMask);

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(x,0f,z).normalized;

        if (dir.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmooth);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(moveDir.normalized * spd * Time.deltaTime);

            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * grv * -2f);
        }

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        

        velocity.y += grv * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
