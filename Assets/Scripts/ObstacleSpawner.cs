using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] allObstacles;
    void Start()
    {
        ObjectSpawner();

    }

   

    void ObjectSpawner()
    {
        int rand = Random.Range(0, allObstacles.Length);
        Instantiate(allObstacles[rand], transform.position, Quaternion.identity);
    }
}
