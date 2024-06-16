using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    bool playing = false;
    float time = 0;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (playing)
            time += Time.deltaTime;

        text.text = time.ToString("00.00");
    }

    public void Restart()
    {
        time = 0;
        playing = true;
    }

    public void Stop()
    {
        playing = false;
    }

    public float getTime()
    {
        return time;
    }
}
