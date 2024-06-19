using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Transform Player;
    private float AttackArea = 30;
    private float SocialDistance = 1.25f;
    private float slowTime = 200;

    float speed;
    bool slowed;
    float slowEndTime;

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

        if (Time.time >= slowEndTime)
            slowed = false;

        float realSpeed = speed;
        if (slowed)
            realSpeed = 1;

        float dis = Vector3.Distance(targetPos, transform.position);
        if (dis <= AttackArea && dis > SocialDistance)
        {
            transform.LookAt(targetPos);
            controller.Move(gameObject.transform.forward * realSpeed * Time.deltaTime);
        }
        //speed = 5;
    }

    public void SetMaxSpeed(float value)
    {
        speed = value;
    }

    public void TriggerSlow()
    {
        if (slowed)
            return;

        slowed = true;
        slowEndTime = Time.time + 2;
    }
}
