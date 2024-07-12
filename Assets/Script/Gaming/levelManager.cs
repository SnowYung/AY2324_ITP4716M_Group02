using System.IO;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public enum Level : int { Easy, Normal, Hard }
public class levelManager : MonoBehaviour
{
    public GameObject levelUI;

    private static Level level;

    public FirstPersonController fpsController;
    public GenerrateEnemy generateControl;
    public Timer timer;
    public RecordList recordList;

    private SrPlayerHP playerHP;

    public CanvasGroup LoseUI;
    float time;
    float fadeDuration = 1f;

    Vector3 startpos;

    public Transform[] pos;
    private CharacterController rb;

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
        rb = fpsController.GetComponent<CharacterController>();
        SetPos();
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
                Reset();
                time = 0;
            }
        }
    }

    public void Easy()
    {
        level = Level.Easy;
        generateControl.Generrate((int)Random.Range(10, 20), (float)Random.Range(5, 9));
        timer.Restart();
        Time.timeScale = 1f;
        SrM1HP.HP = Random.Range(0.08f, 0.1f);
        SrPlayerHP.damage = Random.Range(0.05f, 0.07f);
        //Debug.Log(SrM1HP.HP);
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
        recordList.ShowRecord(level);
    }

    public void Normal()
    {
        level = Level.Normal;
        generateControl.Generrate((int)Random.Range(21, 31), (float)Random.Range(10, 14));
        timer.Restart();
        Time.timeScale = 1f;
        SrM1HP.HP = Random.Range(0.05f, 0.07f);
        SrPlayerHP.damage = Random.Range(0.07f, 0.09f);
        //Debug.Log(SrM1HP.HP);
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
        recordList.ShowRecord(level);
    }

    public void Hard()
    {
        level = Level.Hard;
        generateControl.Generrate((int)Random.Range(32, 42), (float)Random.Range(15, 19));
        timer.Restart();
        Time.timeScale = 1f;
        SrM1HP.HP = Random.Range(0.02f, 0.04f);
        SrPlayerHP.damage = Random.Range(0.09f, 0.12f);
        //Debug.Log(SrM1HP.HP);
        levelUI.gameObject.SetActive(false);
        fpsController.SetCursorVisibility(true);
        recordList.ShowRecord(level);
    }

    public void Pos()
    {
        int SP = Random.Range(0, pos.Length);
        startpos = pos[SP].position;
        startpos.y += 5;
        //Debug.Log(startpos);
    }

    public void SetPos()
    {
        rb.enabled = false;
        Pos();
        fpsController.transform.position = startpos;

        if (fpsController.transform.position == startpos)
        {
            rb.enabled = true;
        }
    }

    public void SetEnemy()
    {
        GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject M1 in enemy)
        {
            Destroy(M1);
            //Debug.Log(enemy.Length);
        }

        generateControl.Generrate(GenerrateEnemy.Num, GenerrateEnemy.Speed);
    }

    public void Reset()
    {
        GameObject.Find("Enermys").GetComponent<updataNum>().ResetMark();
        SetPos();
        SetEnemy();
        timer.Restart();
        playerHP.ResetHP();
        LoseUI.alpha = 0;

    }
}
