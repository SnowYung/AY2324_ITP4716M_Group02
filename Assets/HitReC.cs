using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitReC : MonoBehaviour
{
    public Image image; 
    public CanvasGroup HitRe;
    float fadeDuration = 1f;
    float timer;
    bool done= false;
    bool showing = true;
    float showEndTime;
    
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (done)
        {
            if (Time.time >= showEndTime)
                showing = false;
        }
    }
    public void show()
    {
        if (showing)
            return;
        timer += Time.deltaTime;
        HitRe.alpha = timer / fadeDuration;
        showing = true;
        showEndTime = Time.time + 2;
        Debug.Log("A");
    }
    public void Go()
    {
        done = true;
    }

}
    


