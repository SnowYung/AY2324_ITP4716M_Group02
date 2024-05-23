using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SrM1HP : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        if (M1HP.fillAmount == 0)
        {
            GameObject.Find("Enermys").GetComponent<updataNum>().UpdateMark();
            Destroy(gameObject);
            NumText.UpdateNum(1);
        }
    }
    public Image M1HP;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerWeapon")
        {
            M1HP.fillAmount -= 0.2f;
            GameObject.Find("M1(Clone)").GetComponent<EnemyAI>().setspeed();
            Debug.Log("1");
        }
    }
}
