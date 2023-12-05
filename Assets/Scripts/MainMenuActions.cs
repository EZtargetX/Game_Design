using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuActions : MonoBehaviour
{
    public void GoToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void GoLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void GoToOptions()
    {
        SceneManager.LoadScene("Options Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
