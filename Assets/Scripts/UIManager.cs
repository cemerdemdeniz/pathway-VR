using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject _returnMenuUI;
    public GameObject gun;

    FollowerHealth followerHealth;

    private void Start()
    {
        followerHealth = GameObject.Find("Follower").GetComponent<FollowerHealth>();
    }
    private void Update()
    {
        if (followerHealth.health <= 0)
        {
            _returnMenuUI.SetActive(true);
        }
        else
        {
            _returnMenuUI.SetActive(false);
        }
    }

    public void ChangeColourGreen()
    {
        gun.GetComponent<Renderer>().material.color = Color.green;
    }

    public void ChangeColourPurple()
    {
        gun.GetComponent<Renderer>().material.color = Color.magenta;
    }

    public void ChangeColourBlue()
    {
        gun.GetComponent<Renderer>().material.color = Color.blue;
    }
}
