﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HackerMM : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("The Room", 0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
