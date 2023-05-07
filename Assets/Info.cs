using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
