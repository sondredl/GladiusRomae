using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    private static Animator animator;
    public static bool isAlive;
    public int maxHealth = 100;
    private static int currentHealth;
    public static HealthBar healthBar;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(21);
            // animator.SetTrigger("Die");
        }
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

    public static void TakeDamage(int damage)
    {
        Debug.Log(currentHealth);
        currentHealth -= damage;
        // animator.SetTrigger("isDead");
        if (currentHealth <= 0)
        {
            Debug.Log("player died");
            isAlive = false;
            // animator.SetTrigger("Die");
        }
        healthBar.SetHealth(currentHealth);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged" || collision.gameObject.tag == "Damage_10")
        {
            TakeDamage(damage);
            Debug.Log(damage);
            //Debug.Log("collision caused by an Untagged game object");
            //Debug.Log(currentHealth);
            //currentHealth -= 20;
            //playerHealth.TakeDamage(damage);
        }
        //Debug.Log("collision has occured");
    }
}
