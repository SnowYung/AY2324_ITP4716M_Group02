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
    }

    
    void Update()
    {
        if (playerHP.GetHP() < 0.1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
