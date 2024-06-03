using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public enum Level { Easy, Normal, Hard }
public class levelManager : MonoBehaviour
{
    public GameObject levelUI;

    private static Level level;

    public FirstPersonController fpsController;

    public static Level GetLevel()
    {
        Debug.Log("level");
        return level;
    }

    void Start()
    {
        Time.timeScale = 0f;
        levelUI.gameObject.SetActive(true);
        fpsController.SetCursorVisibility(false);
    }

    
    void Update()
    {
        
    }

    public void Easy()
    {
        level = Level.Easy;
        Time.timeScale = 1f;
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
    }

    public void Normal()
    {
        level = Level.Normal;
        Time.timeScale = 1f;
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
    }

    public void Hard()
    {
        level = Level.Hard;
        Time.timeScale = 1f;
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
    }

    //public void SetEasy()
    //{
    //    level = Level.Easy;
    //}

    //public void SetNormal()
    //{
    //    level = Level.Normal;
    //}

    //public void SetHard()
    //{
    //    level = Level.Hard;
    //}

}
