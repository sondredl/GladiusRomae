using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("shield colission");
        if (collision.gameObject.tag == "Opponent")
        {
            Debug.Log("shield.OnCollisionEnter() shield collision with opponent");
            // PlayerHealth.TakeDamage(damage);
        }
    }
}
