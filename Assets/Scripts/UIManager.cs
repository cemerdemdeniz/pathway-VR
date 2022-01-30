using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject gun;
    Obstacle obstacleColour;

    public GameObject obstacle;

    private void Start()
    {
        obstacleColour = obstacle.GetComponentInChildren<Obstacle>();
    }

    public void ChangeColourGreen()
    {
        //obstacleColour.mode = Obstacle.Mode.Green;
        gun.GetComponent<Renderer>().material.color = Color.green;
    }

    public void ChangeColourPurple()
    {
        //obstacleColour.mode = Obstacle.Mode.Magenta;
        gun.GetComponent<Renderer>().material.color = Color.magenta;
    }

    public void ChangeColourBlue()
    {
        //obstacleColour.mode = Obstacle.Mode.Blue;
        gun.GetComponent<Renderer>().material.color = Color.blue;
    }
}
