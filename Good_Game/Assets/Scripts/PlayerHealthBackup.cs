using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;

public class PlayerHealthBackup : MonoBehaviour
{

    public static bool isAlive;
    public int maxHealth = 100;
    public bool alive;
    public static int currentHealth;
    public HealthBar healthBar;

    float fallTime = 0;
    bool hasFallen = false;
    int damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        isAlive = true;
        healthBar.SetMaxHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //	TakeDamage(20);
        //}
        alive = isAlive;
        if (GetComponent<Rigidbody>().velocity.y < 1)
        {
            fallTime += Time.deltaTime;
            hasFallen = true;
            //            Debug.Log(fallTime);
        }
        else if (hasFallen)
        {
            if (fallTime > 1)
            {
                Debug.Log("has fallen");
                Debug.Log(fallTime);
                TakeDamage(30);
            }
            // Reset fall measurements
            hasFallen = false;
            fallTime = 0;
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            isAlive = false;
        }
        healthBar.SetHealth(currentHealth);
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("collision has occured");
        if (collision.gameObject.tag == "Untagged")
        {
            TakeDamage(damage);
            //Debug.Log(damage);
            //Debug.Log("collision caused by an Untagged game object");
            //Debug.Log(currentHealth);
            //currentHealth -= 20;
            //playerHealth.TakeDamage(damage);
        }
    }
}
