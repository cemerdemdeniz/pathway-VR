using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameSceneManagement : MonoBehaviour
{  

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void ReturnMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

}




   




