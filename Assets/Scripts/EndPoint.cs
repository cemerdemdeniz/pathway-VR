using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour ,IBehaviourOnPoint
{
    public void BehaveOnPoint()
    {
        StartCoroutine(ArrivedToEndPoint(1));
        Debug.Log("NextLevel");
    }

    IEnumerator ArrivedToEndPoint(float delay)
    {
        yield return new WaitForSeconds(delay);
    }
}
   

