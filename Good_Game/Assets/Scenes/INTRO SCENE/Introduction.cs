using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour
{
    void OnEnable()
    {
        //SceneManager.LoadScene("PettersMap", LoadSceneMode.Single);

        // laster neste scene i build indexen
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
