using System.Collections.Generic;
using System.Linq;
using System.IO;
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

    public Timer timer;

    public Level currentLevel;
    public float time;


    private void Awake()
    {
        path = Path.Combine(System.Environment.CurrentDirectory, "List.txt");

        string result = File.ReadAllText(path);
        if (!string.IsNullOrWhiteSpace(result) || string.IsNullOrWhiteSpace(result))
        {
            easyRecords = JsonUtility.FromJson<BestRecord>(result).measyRecords;
            normalRecords = JsonUtility.FromJson<BestRecord>(result).mnormalRecords;
            hardRecords = JsonUtility.FromJson<BestRecord>(result).mhardRecords;
        }
    }

    void Start()
    {
        currentLevel = levelManager.GetLevel();
    }

    [ContextMenu("GetTimeRecord")]
    public void GetTimeRecord()
    {
        time = timer.getTime();

        switch (currentLevel)
        {
            case Level.Easy:
                easyRecords.Add(time);
                easyRecords = easyRecords.OrderBy(o => o).Take(5).ToList();
                break;
            case Level.Normal:
                normalRecords.Add(time);
                normalRecords = normalRecords.OrderBy(o => o).Take(5).ToList();
                break;
            case Level.Hard:
                hardRecords.Add(time);
                hardRecords = hardRecords.OrderBy(o => o).Take(5).ToList();
                break;
        }
        BestRecord r = new BestRecord { measyRecords = easyRecords, mnormalRecords = normalRecords, mhardRecords = hardRecords };
        File.WriteAllText(path, JsonUtility.ToJson(r));
    }
}
