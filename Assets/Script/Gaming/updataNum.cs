using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updataNum : MonoBehaviour
{
    int Mark = 0;
    public CanvasGroup WinUI;
    public Timer gameplayTimer;
    float timer;
    float fadeDuration = 1f;
    public TimerRecord timeRecord;
    bool timeRecordCalled;

    public void Start()
    {

    }
    void Update()
    {
        if (Mark == GenerrateEnemy.Num)
        {
            gameplayTimer.Stop();

            timer += Time.deltaTime;
            WinUI.alpha = timer / fadeDuration;

            //GameObject.Find("Sound").GetComponent<AudioGamingManager>().StopMusic();

            if (timer > fadeDuration + 2f)
                GameObject.Find("Enermys").GetComponent<NextGame>().UI();
        }
    }

    public void UpdateMark()
    {
        Mark += 1;

        if (!timeRecordCalled && Mark == GenerrateEnemy.Num)
        {
            timeRecord.GetTimeRecord();
            timeRecordCalled = true;
        }
    }

    public void ResetMark()
    {
        Mark = 0;
    }
    
}
