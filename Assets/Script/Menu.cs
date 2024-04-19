using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class Menu : MonoBehaviour
{
    public GameObject MenuUI;

    public FirstPersonController fpsController;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            StopGame();
            fpsController.SetCursorVisibility(false);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            BackGame();
            fpsController.SetCursorVisibility(true);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ExitGame();
        }
    }

    public void StopGame()
    {
        Time.timeScale = 0f;
        MenuUI.gameObject.SetActive(true);
    }

    public void BackGame()
    {
        Time.timeScale = 1f;
        MenuUI.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("UI");
    }
}
