using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelchange : MonoBehaviour
{
    public GameObject levelUI;

    public int speed = 0;

    void Start()
    {
        Time.timeScale = 0f;
        levelUI.gameObject.SetActive(true);
    }

    
    void Update()
    {
        
    }

    void Easy()
    {
        EnemyAI[] array = FindObjectsOfType<EnemyAI>();
        foreach (EnemyAI enemy in array)
        {
            //enemy.speed = 5;
        }
    }

    void Normal()
    {

    }

    void Hard()
    {

    }

}
