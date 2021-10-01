//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GladiatorBehaviour : MonoBehaviour
//{
//    private CharacterController controller;
//    private GladiatorBehaviour C_gladiator;
//    private Vector3 C_Move;
//    private bool C_jump = false;
//    private float C_speed = 2.0f;
//    private float jumpHeight = 1f;
//    private float g = -9.8f;

//    // Start is called before the first frame update
//    void Start()
//    {
//        controller = gameObject.AddComponent<CharacterController>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        C_jump = controller.isGrounded;
//        if (C_jump && C_Move.y < 0f)
//        {
//            C_Move.y = 0f;
//        }

//        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
//        controller.Move(move * Time.deltaTime * C_speed);

//        if(move!= Vector3.zero)
//        {
//            gameObject.transform.forward = move;

//        }

//        if(Input.GetButtonDown("Jump") && C_jump)
//        {
//            C_Move.y += Mathf.Sqrt (jumpHeight * -3.0f * g);
//        }
//        C_Move.y += g * Time.deltaTime;
//        controller.Move(C_Move * Time.deltaTime);

//    }

    
//    void input()
//    {
        
//    }
//}
