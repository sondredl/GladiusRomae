using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

	public bool isAlive;
	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;

//	public pause_menu.pause();
//	GameObject pause_menu.pauseMenuUI.SetActive();
//	pause_menu.GameIsPaused isPaused;

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
			TakeDamage(20);
		}
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		if(currentHealth <= 0 ) {
			isAlive = false;

//			pauseMenuUI.SetActive(true);
//			Time.timeScale = 0f;
//			isPaused = true;
		}
		healthBar.SetHealth(currentHealth);
	}
}
