using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    //public int playerHealth;
    int damage;
    public PlayerHealth playerHealth;
    public PlayerHealth currentHealth ;

    void Start()
    {
        //playerHealth = 50;
        damage = 10;
        Debug.Log(playerHealth);
        // set tag of this game object
    }

    void OnColalisionEnter(Collision collision)
    {
        Debug.Log("collision has occured");
        if(collision.gameObject.tag == "Untagged")
        {
            Debug.Log(damage);
            Debug.Log("collision caused by an Untagged game object");
            Debug.Log(currentHealth);
            //currentHealth -= 20;
            //playerHealth.TakeDamage(damage);
        }
    }
}

