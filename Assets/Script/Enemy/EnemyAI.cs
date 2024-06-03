using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    private Transform Player;
    private float AttackArea = 30;
    private float speed = 5;
    private float slowTime = 200;

    private CharacterController controller;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        controller = GetComponent<CharacterController>();
    }

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
        //speed = 5;
    }
    public void setspeed()
    {
        for (int timer = 0; timer < slowTime; timer++)
        {
            speed = 1;
        }
    }

    //public void speed()
    //{
    //    speed = levelchange.speed;
    //}
}
