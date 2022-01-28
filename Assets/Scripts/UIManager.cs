using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gun;
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
