using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerRecord : MonoBehaviour
{
    public Text[] easyRecord = new Text[5];
    public Text[] normalRecord = new Text[5];
    public Text[] hardRecord = new Text[5];


    void Start()
    {
        levelManager.GetLevel();
        GetComponent<Timer>().getTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (levelManager.GetLevel() == Level.Easy)
        {

        }else if(levelManager.GetLevel() == Level.Normal)
        {

        }else if(levelManager.GetLevel() == Level.Hard)
        {

        }
    }
}
