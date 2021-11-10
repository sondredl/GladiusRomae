using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{

    //    public GameObject pauseMenuUI;

    public void PlayGame()
    {
        //        SceneManager.LoadScene("map_1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    //    void update ()
    //    {
    //        if (GameisPaused)
    //        {
    //            pauseMenuUI.gameObject();
    //        }
    //    }
}
