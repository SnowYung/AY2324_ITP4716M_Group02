using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitReC : MonoBehaviour
{
    public Image image; 
    public CanvasGroup HitRe;
    float fadeDuration = 0.05f;
    float timer;
    bool done= false;
    bool showing = true;
    float showEndTime;
    float showResetTime;
    float Restset = 0f;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
       if (done ==true) {
           show();
       }
       if (Time.time >= showEndTime) { 
          showing = false;
       }
       if (Time.time >= showResetTime)
        {
            ResetShow();
        }
    }

    public void show()
    {
        if (showing)
            return;
        timer += Time.deltaTime;
        HitRe.alpha = timer / fadeDuration;
        showEndTime = Time.time + 1;
        showing = true;
        done = false;
        showResetTime = Time.time + 2;
        

    }
    public void ResetShow()
    {
        HitRe.alpha = Restset;
    }
    public void Go()
    {
        done = true;
    }

}
    


