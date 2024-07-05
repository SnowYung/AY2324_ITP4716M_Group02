using System.IO;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SavedRecord
{
    public Level mlevel;
    public float mtime = 0;
}

[System.Serializable]
public struct BestRecord
{
    public List<SavedRecord> measyRecords;
    public List<SavedRecord> mnormalRecords;
    public List<SavedRecord> mhardRecords;
}

public class TimerRecord : MonoBehaviour
{
    public const int maxRecordCol = 5;

    string path;

    public List<SavedRecord> easyRecords = new List<SavedRecord>();
    public List<SavedRecord> normalRecords = new List<SavedRecord>();
    public List<SavedRecord> hardRecords = new List<SavedRecord>();

    public Level currentLevel;
    public float time;


    void Start()
    {
        path = Path.Combine(System.Environment.CurrentDirectory, "output.txt");

        currentLevel = levelManager.GetLevel();
        time = GetComponent<Timer>().getTime();

        string result = File.ReadAllText(path);
        easyRecords = JsonUtility.FromJson<BestRecord>(result).measyRecords;
        normalRecords = JsonUtility.FromJson<BestRecord>(result).mnormalRecords;
        hardRecords = JsonUtility.FromJson<BestRecord>(result).mhardRecords;
    }

    public void GetTimeRecord()
    {
        bool bestRecord = false;
        switch (currentLevel)
        {
            case Level.Easy:
                for (int i = 0; i < maxRecordCol; i++)
                {
                    if (time < easyRecords[i].mtime || easyRecords[i].mtime == 0)
                    {
                        easyRecords.Add(new SavedRecord { mlevel = currentLevel, mtime = time });
                        bestRecord = true;
                        return;
                    }
                }

                if (bestRecord)
                {
                    easyRecords.Sort();
                    if (easyRecords.Count > maxRecordCol)
                    {
                        easyRecords.RemoveAt(maxRecordCol);
                    }
                }
                break;
            case Level.Normal:
                for (int i = 0; i < maxRecordCol; i++)
                {
                    if (time < hardRecords[i].mtime || hardRecords[i].mtime == 0)
                    {
                        hardRecords.Add(new SavedRecord { mlevel = currentLevel, mtime = time });
                        bestRecord = true;
                        return;
                    }
                }

                if (bestRecord)
                {
                    hardRecords.Sort();
                    if (hardRecords.Count > maxRecordCol)
                    {
                        hardRecords.RemoveAt(maxRecordCol);
                    }
                }
                break;
            case Level.Hard:
                for (int i = 0; i < maxRecordCol; i++)
                {
                    if (time < hardRecords[i].mtime || hardRecords[i].mtime == 0)
                    {
                        hardRecords.Add(new SavedRecord { mlevel = currentLevel, mtime = time });
                        bestRecord = true;
                        return;
                    }
                }

                if (bestRecord)
                {
                    hardRecords.Sort();
                    if (hardRecords.Count > maxRecordCol)
                    {
                        hardRecords.RemoveAt(maxRecordCol);
                    }
                }
                break;

                BestRecord r = new BestRecord { measyRecords = easyRecords, mnormalRecords = normalRecords, mhardRecords = hardRecords };

                File.WriteAllText(path, JsonUtility.ToJson(r));
                string result = File.ReadAllText(path);
                easyRecords = JsonUtility.FromJson<BestRecord>(result).measyRecords;
                Debug.Log(easyRecords);
                normalRecords = JsonUtility.FromJson<BestRecord>(result).mnormalRecords;
                hardRecords = JsonUtility.FromJson<BestRecord>(result).mhardRecords;
        }
    }
}
