using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour ,IBehaviourOnPoint
{
    GameSceneManagement _scenes;

    private void Start()
    {
        _scenes = GameObject.Find("GameSceneManagement").GetComponent<GameSceneManagement>();
    }
    public void BehaveOnPoint()
    {
        StartCoroutine(ArrivedToEndPoint(1));
    }

    IEnumerator ArrivedToEndPoint(float delay)
    {
        yield return new WaitForSeconds(delay);
        _scenes.LoadNextScene();
    }
}
   

