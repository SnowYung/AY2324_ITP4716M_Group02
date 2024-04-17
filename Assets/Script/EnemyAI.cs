using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    private Transform Player;
    private float AttackArea = 30;
    //int set = -90;
    private float speed = 8;

    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = Player.position;

        targetPos.y = transform.position.y;

        float dis = Vector3.Distance(targetPos, transform.position);
        
        if (dis <= AttackArea)
        {
            transform.LookAt(targetPos);
            controller.Move(gameObject.transform.forward * speed * Time.deltaTime);
            
        }
        
    }
}
