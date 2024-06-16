using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyWeapon : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            other.GetComponent<SrPlayerHP>().TakeDamage(0.2f);
        }
    }
}
