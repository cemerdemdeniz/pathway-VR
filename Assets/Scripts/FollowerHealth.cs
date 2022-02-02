using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FollowerHealth : HealthSystem, IInteractableWithObstacle
{

    public GameObject healthbarUI;
    public Slider slider;

    GameSceneManagement _scenes;
    void Start()
    {
        _scenes = GameObject.Find("GameSceneManagement").GetComponent<GameSceneManagement>();
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    void Update()
    {
        slider.value = CalculateHealth();

        LessThanMaxHealth();
        LessThanZero();
        GreaterThanMaxHealth();
    }
    
    public void InteractObstacle()
    {
        health -= 50;
    }   
   

    public override float CalculateHealth()
    {
        return health / maxHealth;
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
        {
            StartCoroutine(OnDeadFollower(0.25f));
        }
        return true;
    }

    IEnumerator OnDeadFollower(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(this.gameObject);

    }
}
