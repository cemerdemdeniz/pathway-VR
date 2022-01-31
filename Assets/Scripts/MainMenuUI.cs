using System.Collections;
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
        StartCoroutine(LoadNextScene(1));
    }

    public void OptionsMenu()
    {
        StartCoroutine(OptionsMenu(1));
    }

    public void BackToMenu()
    {
        StartCoroutine(BackToMenu(1));
    }

    public void Difficulty()
    {
        StartCoroutine(Difficulty(1));
    }


    #region Numerators
    IEnumerator OptionsMenu(float delay)
    {
        yield return new WaitForSeconds(delay);
        _start.SetActive(false);
        _optionMenu.SetActive(false);
        _backToMenu.SetActive(true);
        _difficulty.SetActive(true);

    }
    IEnumerator LoadNextScene(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    IEnumerator BackToMenu(float delay)
    {
        yield return new WaitForSeconds(delay);
        _start.SetActive(true);
        _optionMenu.SetActive(true);
        _backToMenu.SetActive(false);
        _difficulty.SetActive(false);


    }

    IEnumerator Difficulty(float delay)
    {
        yield return new WaitForSeconds(delay);
        _start.SetActive(false);
        _optionMenu.SetActive(false);
        _backToMenu.SetActive(false);
        _difficulty.SetActive(false);


    }
    #endregion



}
