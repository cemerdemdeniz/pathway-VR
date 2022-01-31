using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleHealth : MonoBehaviour , IInteractable
{
    public float health;
    public float maxHealth;

    public GameObject healthbarUI;
    public Slider slider;

   
    private void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    private void Update()
    {
        slider.value = CalculateHealth();

        if(health < maxHealth)
        {
            healthbarUI.SetActive(true);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculateHealth()
    {
        return health / maxHealth;
       
    }

    public void TakeDamage()
    {
        health -= 25;
    }
}
