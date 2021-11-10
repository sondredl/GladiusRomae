using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement1 : MonoBehaviour
{

    private CharacterController characterController;
    public Transform cam;
    private Animator animator;

    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float backwardSpeed = 5f;
    [SerializeField] private float turnSpeed = 150;
    // [SerializeField] bool m_Crouch = false;
    // public float turnSmoothTime = 0.1f;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var movement = new Vector3(horizontal, 0, vertical).normalized;

        // forward run animation
        animator.SetFloat("Speed", vertical);
        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);

        if (vertical != 0)
        {
            characterController.SimpleMove(transform.forward * moveSpeed * vertical);
        }

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
