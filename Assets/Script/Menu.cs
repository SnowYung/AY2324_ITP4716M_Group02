using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            StopGame();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            BackGame();
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
