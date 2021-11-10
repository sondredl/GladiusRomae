using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
using UnityStandardAssets.CrossPlatformInput;


namespace WarriorAssets.Character {

    [RequireComponent(typeof(AnimationCharacter))]

    public class AnimationController : MonoBehaviour
    {
        private AnimationCharacter m_Character;
        private Transform m_Cam;
        private Vector3 m_camForward;
        private Vector3 m_Move;
        private bool m_Jump;

        // Start is called before the first frame update
        private void Start()
        {

            if(Camera.main != null)
            {
                m_Cam = Camera.main.transform;
            }
            else
            {
                Debug.LogWarning(
                   "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", gameObject);

            }

            m_Character = GetComponent<AnimationCharacter>();     
         }


        // Update is called once per frame
        private void Update()
        {
            if (!m_Jump)
            {
                m_Jump = CrossPlatformInputManager.GetButton("Jump");
            }
        }


    }
}
*/

public class AnimationController1 : MonoBehaviour
{

    //Variables
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;

    private Vector3 moveDirection;
    private Vector3 velocity;

    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float gravity;

    [SerializeField] private float jumpHeight;

    //References
    private CharacterController controller;
    private Animator anim;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attack();
        }
    }

    private void Move()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }


        float moveZ = Input.GetAxis("Vertical");

        moveDirection = new Vector3(0, 0, moveZ);
        moveDirection = transform.TransformDirection(moveDirection);

        if (isGrounded)
        {

            if (moveDirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
            {
                //walk 
                walk();
            }
            else if (moveDirection != Vector3.zero && Input.GetKeyDown(KeyCode.LeftShift))
            {
                //run 
                run();
            }
            else if (moveDirection == Vector3.zero)
            {
                //Idle
                Idle();
            }

            moveDirection *= moveSpeed;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                jump();
            }
        }

        controller.Move(moveDirection * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }


    private void Idle()
    {
        anim.SetFloat("Speed", 0, 0.1f, Time.deltaTime);
    }

    private void walk()
    {
        moveSpeed = walkSpeed;
        anim.SetFloat("Speed", 0.5f, 0.1f, Time.deltaTime);
    }

    private void run()
    {
        moveSpeed = runSpeed;
        anim.SetFloat("Speed", 1, 0.1f, Time.deltaTime);

    }

    private void jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);

    }

    private void attack()
    {
        anim.SetTrigger("Attack");
    }

    private IEnumerator Attack()
    {
        anim.SetLayerWeight(anim.GetLayerIndex("Attack Layer"), 1);
        anim.SetTrigger("Attack");
        yield return new WaitForSeconds(0.9f);

    }
}