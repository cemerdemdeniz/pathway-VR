using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject _optionMenu;
    public GameObject _start;
    public GameObject _difficulty;
    GameSceneManagement _scenes;
    private void Start()
    {
        _scenes = GameObject.Find("GameSceneManagement").GetComponent<GameSceneManagement>();

    }
    public void LoadNextScene()
    {
        _scenes.LoadNextScene();
    }

    public void OptionsMenu()
    {
        _difficulty.SetActive(true);
    }

   



}
