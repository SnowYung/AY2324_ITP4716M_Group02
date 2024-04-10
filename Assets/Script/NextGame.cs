using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextGame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Gaming");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
