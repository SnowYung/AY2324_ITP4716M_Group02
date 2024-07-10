using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class SavedRecord
{
    public Level mlevel;
    public float mtime = 0;
}

[System.Serializable]
public struct BestRecord
{
    public List<float> measyRecords;
    public List<float> mnormalRecords;
    public List<float> mhardRecords;
}

public class TimerRecord : MonoBehaviour
{
    public const int maxRecordCol = 5;

    string path;

    public List<float> easyRecords = new List<float>();
    public List<float> normalRecords = new List<float>();
    public List<float> hardRecords = new List<float>();

    public Level currentLevel;
    public float time;
    public float temp;

    void Start()
    {
        path = Path.Combine(System.Environment.CurrentDirectory, "output.txt");

        currentLevel = levelManager.GetLevel();

        string result = File.ReadAllText(path);
        easyRecords = JsonUtility.FromJson<BestRecord>(result).measyRecords;
        normalRecords = JsonUtility.FromJson<BestRecord>(result).mnormalRecords;
        hardRecords = JsonUtility.FromJson<BestRecord>(result).mhardRecords;
        print(easyRecords.Count);
    }

    //public void sort(float[] timeList)
    //{

    //    //for (int i = 0; i < timeList.Length; i++)
    //    //{
    //        for (int j = 0; j < timeList.Length; j++)
    //        {
    //            if (timeList[j] > timeList[j + 1])
    //            {
    //            temp = timeList[j];

    //            timeList[j + 1] = timeList[j];

    //            timeList[j + 1] = temp;
    //            }
    //        }
    //    //}
    //}

    [ContextMenu("GetTimeRecord")]
    public void GetTimeRecord()
    {
        bool bestRecord = false;
        float newRecord = 0;
        switch (currentLevel)
        {
            case Level.Easy:
                if (easyRecords.Count == 0)
                {
                    newRecord = time;
                }
                else
                {
                    for (int i = 0; i < easyRecords.Count; i++)
                    {
                        if (time < easyRecords[i])
                        {
                            newRecord = time;
                            break;
                        }
                    }
                }

                if (newRecord > 0)
                {

                    easyRecords.Add(time);
                    easyRecords.Sort();
                    if (easyRecords.Count > maxRecordCol)
                    {
                        easyRecords.RemoveAt(maxRecordCol);
                    }
                }
                break;
                //case Level.Normal:
                //    for (int i = 0; i < normalRecords.Count; i++)
                //    {
                //        if (time < normalRecords[i].mtime || hardRecords[i].mtime == 0)
                //        {
                //            hardRecords.Add(new SavedRecord { mlevel = currentLevel, mtime = time });
                //            bestRecord = true;
                //            break;
                //        }
                //    }

                //    if (bestRecord)
                //    {
                //        hardRecords.Sort();
                //        if (hardRecords.Count > maxRecordCol)
                //        {
                //            hardRecords.RemoveAt(maxRecordCol);
                //        }
                //    }
                //    break;
                //case Level.Hard:
                //    for (int i = 0; i < hardRecords.Count; i++)
                //    {
                //        if (time < hardRecords[i].mtime || hardRecords[i].mtime == 0)
                //        {
                //            hardRecords.Add(new SavedRecord { mlevel = currentLevel, mtime = time });
                //            bestRecord = true;
                //            break;
                //        }
                //    }

                //    if (bestRecord)
                //    {
                //        hardRecords.Sort();
                //        if (hardRecords.Count > maxRecordCol)
                //        {
                //            hardRecords.RemoveAt(maxRecordCol);
                //        }
                //    }
                //    break;


        }
        BestRecord r = new BestRecord { measyRecords = easyRecords, mnormalRecords = normalRecords, mhardRecords = hardRecords };

        File.WriteAllText(path, JsonUtility.ToJson(r));
        string result = File.ReadAllText(path);
        easyRecords = JsonUtility.FromJson<BestRecord>(result).measyRecords;
        Debug.Log(easyRecords);
        normalRecords = JsonUtility.FromJson<BestRecord>(result).mnormalRecords;
        Debug.Log(normalRecords);
        hardRecords = JsonUtility.FromJson<BestRecord>(result).mhardRecords;
        Debug.Log(hardRecords);
    }
}
