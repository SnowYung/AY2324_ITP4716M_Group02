using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class updataNum : MonoBehaviour
{
    int Mark = 0;
    public CanvasGroup BackGroundUI;
    public Timer gameplayTimer;
    float timer;
    float fadeDuration = 1f;

    public int NumofEnemy;

    void Update()
    {
        if (Mark == NumofEnemy)
        {
            gameplayTimer.Stop();

            timer += Time.deltaTime;
            BackGroundUI.alpha = timer / fadeDuration;
            if(timer > fadeDuration + 2f)
            {
                GameObject.Find("Enermys").GetComponent<NextGame>().UI();
                GameObject.Find("Sound").GetComponent<AudioGamingManager>().StopMusic();
            }
        }
    }

    public void UpdateMark()
    {
        Mark = Mark + 1;
    }

    public void ResetMark()
    {
        Mark = 0;
    }

}
