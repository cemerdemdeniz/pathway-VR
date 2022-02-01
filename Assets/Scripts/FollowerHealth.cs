using UnityEngine;
using UnityEngine.UI;

public class FollowerHealth : MonoBehaviour, IInteractableWithObstacle
{
    public float health;
    public float maxHealth;

    public GameObject healthbarUI;
    public Slider slider;
    void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    void Update()
    {
        slider.value = CalculateHealth();

        if (health < maxHealth)
            healthbarUI.SetActive(true);

        if (health <= 0)
            Destroy(this.gameObject);

        if (health > maxHealth)
            health = maxHealth;


    }
    float CalculateHealth()
    {
        return health / maxHealth;

    }
    public void InteractObstacle()
    {
        health -= 50;
    }

    


}
