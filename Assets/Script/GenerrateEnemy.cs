using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerrateEnemy : MonoBehaviour
{
    public GameObject M1Position;
    public GameObject M1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0;  i<10; i++)
        {
            GameObject enemy =  Instantiate(M1Position, new Vector3((float)(Random.Range(-50, 50)), 0, (float)(Random.Range(-50, 50))), new Quaternion(0f, 0f, 0f, 0f), M1.transform);
            //enemy.transform.parent = M1.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
