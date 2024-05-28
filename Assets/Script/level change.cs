using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelchange : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Easy()
    {
        EnemyAI[] array = FindObjectsOfType<EnemyAI>();
        foreach (EnemyAI enemy in array)
        {
            //enemy.setspeed;
        }
    }

    public void Normal()
    {

    }

    public void Diff()
    {

    }

}
