﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menus : MonoBehaviour

{

    GameObject scoreText;

    void Start()
    {
        scoreText = GameObject.Find("Score");
        scoreText.GetComponent<Text>().text = "Score: " + PlayerPrefs.GetString("Score");
    }

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
