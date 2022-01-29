using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 
    pause_menu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.isAlive == false)
        {
            Debug.Log("pause_menu you died! in");
            Pause();
        }
        // if (PlayerHealth.isAlive == false)
        // {
        //     PlayerMovement.animator.SetTrigger("Die");
        //     Debug.Log("pause_menu you died! in");
        //     Pause();
        // }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        //Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("LoadMenu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu_testV2");
        pauseMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
}
