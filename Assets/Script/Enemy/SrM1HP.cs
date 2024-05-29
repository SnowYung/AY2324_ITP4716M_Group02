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
            GameObject.Find("Enemys").GetComponent<updataNum>().UpdateMark();
            Destroy(gameObject);
            NumText.UpdateNum(1);
        }
    }
    public Image M1HP;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerWeapon")
        {
            M1HP.fillAmount -= 0.1f;
            GetComponent<EnemyAI>().setspeed();
        }
    }
}
