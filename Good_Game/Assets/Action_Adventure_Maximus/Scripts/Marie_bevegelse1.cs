using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marie_bevegelse1 : MonoBehaviour
{
    // private CharacterController characterController;

    private void Awake()
    {
        // characterController = GetComponent<characterController>();
    }
      
   private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var movement = new Vector3(horizontal, 0, vertical);

    }
}
