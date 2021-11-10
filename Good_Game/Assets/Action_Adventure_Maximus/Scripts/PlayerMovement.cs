using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    private CharacterController characterController;
    public Transform cam;
    private Animator animator;
    private bool isGrounded;

    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float backwardSpeed = 5f;
    [SerializeField] private float turnSpeed = 150;
    // [SerializeField] bool m_Crouch = false;
    // public float turnSmoothTime = 0.1f;
    [SerializeField] public float gravity = 9.81f;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var movement = new Vector3(horizontal, gravity, vertical).normalized;

        // forward run animation
        animator.SetFloat("Speed", vertical);
        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);

        if (vertical != 0)
        {
            // characterController.SimpleMove(transform.forward * moveSpeed * vertical * gravity);
            characterController.SimpleMove(transform.forward * moveSpeed * vertical);
        }
        if (!characterController.isGrounded) movement -= new Vector3(0, gravity * Time.deltaTime, 0);
        characterController.SimpleMove(Physics.gravity);

        // ############################################
        // Vector3 foward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * MoveSpeed;
        // transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime, 0));
        // cc.Move(foward * Time.deltaTime);

        // currentMovement = new Vector3(0, currentMovement.y, Input.GetAxis("Vertical") * MoveSpeed);
        // currentMovement = transform.rotation * currentMovement;
        // if (!cc.isGrounded) currentMovement -= new Vector3(0, gravity * Time.deltaTime, 0);
        //cc.SimpleMove(Physics.gravity);
        // ############################################

        // left and right mouse click attack
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
            Debug.Log("attack trigger engaged");
        }
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetTrigger("Attack2");
            Debug.Log("attack 2 trigger engaged");
        }

        // animator.SetTrigger("Jump");
        // transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);

        // backward run animation
        // animator.SetFloat("Speed", vertical);
        // transform.Rotate(Vector3.down, horizontal * turnSpeed * Time.deltaTime);

        // var attack = new bool();

        // characterController.SimpleMove(movement * Time.deltaTime * moveSpeed);
        // // characterController(attack);

        // animator.SetFloat("Speed", movement.magnitude);
        // // animator.SetBool("Fire1", attack);

        // if (movement.magnitude > 0)
        // {
        //     Quaternion newDirection = Quaternion.LookRotation(movement);
        //     transform.rotation = Quaternion.Slerp(transform.rotation, newDirection, Time.deltaTime * turnSpeed);

        //     // float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        //     // float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSpeed, turnSmoothTime);
        //     // transform.rotation = Quaternion.Euler(0f, angle, 0f);

        //     // Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
        //     // characterController.Move(moveDir.normalized * moveSpeed * Time.deltaTime);
        // }
    }
}
