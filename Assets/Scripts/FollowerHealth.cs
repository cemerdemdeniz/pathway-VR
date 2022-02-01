using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FollowerHealth : MonoBehaviour, IInteractableWithObstacle
{
    public float health;
    public float maxHealth;

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

        if (health < maxHealth)
            healthbarUI.SetActive(true);

        if (health <= 0)
        {
            StartCoroutine(OnDeadFollower(0.25f));
        }
           

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


    IEnumerator OnDeadFollower(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(this.gameObject);
        
    }


}
