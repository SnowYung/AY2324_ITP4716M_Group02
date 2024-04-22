using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class updataNum : MonoBehaviour
{
    int Mark = 0 ;
    public CanvasGroup BackGroundUI;
    float timer;
    float fadeDuration = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Mark == 10)
        {
            timer += Time.deltaTime;
            BackGroundUI.alpha = timer / fadeDuration;
            if(timer> fadeDuration + 2f)
            {
                GameObject.Find("Enermys").GetComponent<NextGame>().UI();
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
