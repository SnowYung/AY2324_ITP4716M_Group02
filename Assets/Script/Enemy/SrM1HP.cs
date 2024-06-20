using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SrM1HP : MonoBehaviour
{
    public Image M1HP;

    void Update()
    {
        if (M1HP.fillAmount <= 0)
        {
            GameObject.Find("Enermys").GetComponent<updataNum>().UpdateMark();
            Destroy(gameObject);
           //GameObject.Find("FPSController").GetComponent<SrPlayerHP>().TransformA();
            
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerWeapon")
        {
            M1HP.fillAmount -= 0.1f;
            GetComponent<EnemyAI>().TriggerSlow();
        }
    }
}
