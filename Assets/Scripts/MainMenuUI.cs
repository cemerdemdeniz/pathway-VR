using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject _backToMenu;
    public GameObject _optionMenu;
    public GameObject _start;
    public GameObject _difficulty;
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);      
        
    }

    public void OptionsMenu()
    {
        _start.SetActive(false);
        _optionMenu.SetActive(false);
        _backToMenu.SetActive(true);
        _difficulty.SetActive(true);
    }

    public void BackToMenu()
    {
        _start.SetActive(true);
        _optionMenu.SetActive(true);
        _backToMenu.SetActive(false);
        _difficulty.SetActive(false);
    }

    public void Difficulty()
    {
        _start.SetActive(false);
        _optionMenu.SetActive(false);
        _backToMenu.SetActive(false);
        _difficulty.SetActive(false);
    }



}
