using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class NextGame : MonoBehaviour
{
    public FirstPersonController fpsController;

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Gaming");
    }
    public void UI()
    {
        fpsController.SetCursorVisibility(false);
        SceneManager.LoadSceneAsync("UI");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
