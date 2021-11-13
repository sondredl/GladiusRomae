using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeHealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetNewMaxHealth(int health)
    {
        Debug.Log("(meleeHealthBar)SetNewMaxHealth: " + health);
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetNewHealth(int health)
    {
        Debug.Log("(meleeHealthBar)SetNewHealth: " + health);
        slider.value = health;
        // animator.SetTrigger("Die");
    }
    // public void SetMaxHealth(int health)
    // {
    //     Debug.Log("(healthBar)SetMaxHealth: " + health);
    //     slider.maxValue = health;
    //     slider.value = health;
    // }


    // public void SetHealth(int health)
    // {
    //     Debug.Log("(healthBar)SetHealth");
    //     slider.value = health;
    //     // animator.SetTrigger("Die");
    // }
}
