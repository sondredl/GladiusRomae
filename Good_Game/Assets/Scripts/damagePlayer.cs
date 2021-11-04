using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagePlayer : MonoBehaviour
{
    public int playerHealth;
    int damage;

    void Start()
    {
        playerHealth = 50;
        damage = 10;
        Debug.Log(playerHealth);
        // set tag of this game object
        rigidbody.gameObject.tag = "player";
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision has occured");
        if(collision.gameObject.tag == "attacker")
        {
            Debug.Log(damage);
        Debug.Log("collision caused by an attacker");
            Debug.Log("enemyDong Just touched something wierd");
        }
    }
}
