using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject _optionMenu;
    public GameObject _start;
    public GameObject _difficulty;
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OptionsMenu()
    {
        _difficulty.SetActive(true);
    }

    public void Difficulty()
    {
      
        
    }  



}
