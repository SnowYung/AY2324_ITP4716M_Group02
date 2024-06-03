using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerrateEnemy : MonoBehaviour
{
    public GameObject M1Position;
    public GameObject M1;

    public GameObject enemy;

    public int i;

    Vector3 position;

    [SerializeField]
    LayerMask layerMask;

    void Start()
    {
        float radius = 1.5f;
        Vector3 genPos;
        Vector3 origin;

        int NumOfEnemy = GetNumOfEnemy();

        for (i=0;  i<NumOfEnemy; i++)
        {
            RaycastHit[] hitInfo;
            bool success;

            int counter = 0;
            do
            {
                genPos = new Vector3((float)(Random.Range(-45, 45)), 0, (float)(Random.Range(-45, 45)));
                origin = genPos + Vector3.up * 20;
                hitInfo = Physics.SphereCastAll(origin, radius, Vector3.down, 21f,layerMask);

                counter++;
            }
            while (hitInfo.Length!=1);

            genPos = hitInfo[0].point;

            //TO be delete start
            //GameObject GenPoint = new GameObject("Gen Point " + i);
            //GenPoint.transform.position = genPos;
            //TO be delete end

            enemy =  Instantiate(M1Position, genPos, new Quaternion(0f, 0f, 0f, 0f), M1.transform);
            //enemy.name = "M1" + i;
        }
    }

    void Update()
    {

    }

    public static int GetNumOfEnemy()
    {
        switch(levelManager.GetLevel())
        {
            case Level.Easy:
                Debug.Log("Easy");
                return 10;
            case Level.Normal:
                Debug.Log("Normal");
                return 15;
            case Level.Hard:
                Debug.Log("Hard");
                return 20;
            default:
                Debug.LogError("Level is invalid");
                return 0;
        }
    } 

}
