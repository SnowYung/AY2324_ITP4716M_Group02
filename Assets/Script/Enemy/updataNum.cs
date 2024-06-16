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

    void Update()
    {
        if (Mark == 10)
        {
            gameplayTimer.Stop();

            timer += Time.deltaTime;
            WinUI.alpha = timer / fadeDuration;
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
