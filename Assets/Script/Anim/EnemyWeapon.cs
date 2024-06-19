using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    private SrPlayerHP target;
    private float nextDamageTime;

    private void Update()
    {
        if (Time.time >= nextDamageTime && target != null)
        {
            target.TakeDamage(0.2f);
            nextDamageTime = Time.time + 1f;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<SrPlayerHP>() != null)
        {
            target = other.GetComponent<SrPlayerHP>();
            nextDamageTime = Time.time;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<SrPlayerHP>() != null)
            target = null;
    }
}
