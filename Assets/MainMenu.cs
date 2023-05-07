using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Setting()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Info()
    {
        SceneManager.LoadScene("Info");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
