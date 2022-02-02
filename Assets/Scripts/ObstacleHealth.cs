using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleHealth : HealthSystem , IInteractable
{
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
        LessThanMaxHealth();
        LessThanZero();
        GreaterThanMaxHealth();
    }
    public override float CalculateHealth()
    {
        return health / maxHealth;
    }

    public void TakeDamage()
    {
        health -= 25;
    }

    public override bool LessThanMaxHealth()
    {
        if (health < maxHealth)
            healthbarUI.SetActive(true);
        return true;
    }

    public override bool GreaterThanMaxHealth()
    {
        if (health > maxHealth)
            health = maxHealth;
        return true;
    }

    public override bool LessThanZero()
    {
        if (health <= 0)
            Destroy(gameObject);
        return true;
    }
}
