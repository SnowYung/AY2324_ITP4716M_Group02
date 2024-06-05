using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float time = 0;

    float stoptime;

    Text text;

    public CanvasGroup GameWin;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (GameWin)
        {

            text.text = Mathf.Floor(time).ToString("00");
        }
    }

    public void Play()
    {
        time += Time.deltaTime;
    }

    public void Stop()
    {
        stoptime = time;
    }
}
