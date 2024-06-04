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
    public GenerrateEnemy generateControl;

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
        generateControl.Generrate(10, 5);
        Time.timeScale = 1f;
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
    }

    public void Normal()
    {
        level = Level.Normal;
        generateControl.Generrate(15, 10);
        Time.timeScale = 1f;
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
    }

    public void Hard()
    {
        level = Level.Hard;
        generateControl.Generrate(20, 15);
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
