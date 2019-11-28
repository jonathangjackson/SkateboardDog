using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour

{
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("CreditsScreen");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlayScreen");

    }

    public void ReturnToStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
