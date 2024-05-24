using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerrateEnemy : MonoBehaviour
{
    public GameObject M1Position;
    public GameObject M1;

    public GameObject enemy;

    void Start()
    {
        for (int i=0;  i<10; i++)
        {
            enemy =  Instantiate(M1Position, new Vector3((float)(Random.Range(-45, 45)), 0, (float)(Random.Range(-45, 45))), new Quaternion(0f, 0f, 0f, 0f), M1.transform);
            //enemy.transform.parent = M1.transform;
            
            if (enemy.transform.position.y > 0 )
            {
                Destroy(gameObject);
                i -= 1;
            }
        }
    }

    void Update()
    {
            //if (enemy.GetComponent<CharacterController>())
            //{

            //}

    }

}
