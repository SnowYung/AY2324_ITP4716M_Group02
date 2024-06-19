using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public enum Level { Easy, Normal, Hard }
public class levelManager : MonoBehaviour
{
    public GameObject levelUI;

    private static Level level;

    public FirstPersonController fpsController;
    public GenerrateEnemy generateControl;
    public Timer timer;

    private SrPlayerHP playerHP;

    public CanvasGroup LoseUI;
    float time;
    float fadeDuration = 1f;

    public Vector3 PlayerPos;

    public static Level GetLevel()
    {
        return level;
    }

    void Start()
    {
        Time.timeScale = 0f;
        levelUI.gameObject.SetActive(true);
        fpsController.SetCursorVisibility(false);
        playerHP = fpsController.GetComponent<SrPlayerHP>();
        PlayerPos = new Vector3(-43, 3, 26);
        transform.position = PlayerPos;
    }


    void Update()
    {
        if (playerHP.GetHP() < 0.1)
        {
            timer.Stop();

            time += Time.deltaTime;
            LoseUI.alpha = time / fadeDuration;

            if (time > fadeDuration + 2f)
            {
                LoseUI.alpha = 0;
                fpsController.enabled = false;
                fpsController.transform.position = PlayerPos;
                fpsController.enabled = true;
                //generateControl.ResetEnemy();
                //generateControl.Generrate(GenerrateEnemy.Num, GenerrateEnemy.Speed);
                timer.Restart();
                playerHP.ResetHP();
                return;
            }
            return;
        }
    }

    public void Easy()
    {
        level = Level.Easy;
        generateControl.Generrate((int)Random.Range(10, 20), (float)Random.Range(5, 9));
        timer.Restart();
        Time.timeScale = 1f;
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
    }

    public void Normal()
    {
        level = Level.Normal;
        generateControl.Generrate((int)Random.Range(21, 31), (float)Random.Range(10, 14));
        timer.Restart();
        Time.timeScale = 1f;
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
    }

    public void Hard()
    {
        level = Level.Hard;
        generateControl.Generrate((int)Random.Range(32, 42), (float)Random.Range(15, 19));
        timer.Restart();
        Time.timeScale = 1f;
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
    }
}
