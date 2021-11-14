using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeHealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image HealthBar;
    MeleeController Player;

    private void Start () {
        HealthBar = GetComponent<Image>();
        Player = FindObjectOfType<MeleeController>();
    }
    private void Update() {
        // SetNewHealth(MeleeController.currentHealth);
        // slider.value = MeleeController.currentHealth;
        // HealthBar.slider = MeleeController.currentHealth;
        SetNewHealth(MeleeController.currentHealth);

    }

    public void SetNewMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        Debug.Log("(meleeHealthBar)SetNewMaxHealth: " + health);
    }

    public void SetNewHealth(int health)
    {
        slider.value = health;
        // MeleeHealthBar.slider = health;
        Debug.Log("(meleeHealthBar)SetNewHealth: " + health);
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
