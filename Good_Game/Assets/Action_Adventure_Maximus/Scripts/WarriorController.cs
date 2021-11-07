using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
    public class WarriorController : MonoBehaviour
    {
        private CharacterController controller;
        private Vector3 playerVelocity;
        private bool groundedPlayer;
        private float playerSpeed = 2.0f;
        private float jumpHeight = 1.0f;
        private float gravityValue = -9.81f;

        private void Start()
        {
            controller = gameObject.AddComponent<CharacterController>();
        }

        void Update()
        {
            groundedPlayer = controller.isGrounded;
            if (groundedPlayer && playerVelocity.y < 0)
            {
                playerVelocity.y = 0f;
                Debug.Log("player grounded and qero velocity");
            }

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * playerSpeed);

            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
                Debug.Log("player moving");
            }

            // // Changes the height position of the player..
            // if (Input.GetButtonDown("Jump") && groundedPlayer)
            // {
            //     playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            // }

            // playerVelocity.y += gravityValue * Time.deltaTime;
            // controller.Move(playerVelocity * Time.deltaTime);
        }
    }
}
