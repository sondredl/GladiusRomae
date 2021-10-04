using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    private CharacterController charController; //can only change inside this class

    public float movement_Speed = 3f;   // is public in the inspection area
    public float gravity = 9.8f;
    public float rotation_Speed = 0.15f;
    public float rotateDDegreesPerSecond = 180f;



    // 1st function that is called

    void Awake()
    {
        charController = GetComponent<CharacterController>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }


    void Move()
    {
        print("The value is " + Input.GetAxis(Axis.VERTICAL_AXIS));

        // Using tag file to get the tags
        
        if(Input.GetAxis(Axis.VERTICAL_AXIS) > 0)
        {
            Vector3 moveDirection = transform.forward;

            moveDirection.y -= gravity * Time.deltaTime;    // getting our gravity 
            charController.Move(moveDirection * movement_Speed * Time.deltaTime);
        }
        // going backward -
        else if (Input.GetAxis(Axis.VERTICAL_AXIS) > 0)
        {
            Vector3 moveDirection = -transform.forward;

            moveDirection.y -= gravity * Time.deltaTime;    // getting our gravity 
            charController.Move(moveDirection * movement_Speed * Time.deltaTime);

        }
 
    }
    void Rotate()
    {
        Vector3 rotation_Direction = Vector3.zero;

        if(Input.GetAxis(Axis.HORIZONTAL_AXIS)< 0)
        {
            rotation_Direction = transform.TransformDirection(Vector3.left);

        }
        if (Input.GetAxis(Axis.HORIZONTAL_AXIS) > 0)
        {
            rotation_Direction = transform.TransformDirection(Vector3.right);


        }

        if(rotation_Direction != Vector3.zero)
        {
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation, Quaternion.LookRotation(rotation_Direction),
                rotateDDegreesPerSecond * Time.deltaTime);
        }

    }//Rotate 

}   //class


























