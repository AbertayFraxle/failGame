using System.Collections;
using System.Collections.Generic;
using UnityEditor;
//using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    bool touchingJump = false;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnTriggerEnter(Collider jumpPad)
    {
        if (jumpPad.gameObject.name == "jumpPad") //Death layer
        {
            Debug.Log("TOUCHING");
            touchingJump = true;
        }
    }

    private void OnTriggerExit(Collider jumpPad)
    {
        if (jumpPad.gameObject.name == "jumpPad") //Death layer
        {
            Debug.Log("NOT TOUCHING");
            touchingJump = false;
        }
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Cancel")){
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            Cursor.lockState = CursorLockMode.None;
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDis, groundMask);

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        //direction
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

        //Jump
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            if (touchingJump == false)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * grv * -2f);
            }
            else
            {
                Debug.Log("WILL JUMP HIGH");
                velocity.y = Mathf.Sqrt(jumpHeight * grv * -10f);
            }
        }

        //Land
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            grv = -9.8f;
        }

        if(velocity.y < 0)
        {
            grv = -19f;
        }

        //Gravity
        velocity.y += grv * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
