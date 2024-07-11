using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordList : MonoBehaviour
{
    [SerializeField]
    public List<Text> Record;

    public TimerRecord timerRecord;

    public void ShowRecord(Level level)
    {
        switch (level)
        {
            case Level.Easy:
                for (int i = 0; i < Record.Count; i++)
                    Record[i].text = timerRecord.easyRecords.Count > i ? timerRecord.easyRecords[i].ToString() : string.Empty;
                break;
            case Level.Normal:
                for (int i = 0; i < Record.Count; i++)
                    Record[i].text = timerRecord.normalRecords.Count > i ? timerRecord.normalRecords[i].ToString() : string.Empty;
                break;
            case Level.Hard:
                for (int i = 0; i < Record.Count; i++)
                    Record[i].text = timerRecord.hardRecords.Count > i ? timerRecord.hardRecords[i].ToString() : string.Empty;
                break;
        }
    }
}
