using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SrM1HP : MonoBehaviour
{
    int GameOver = 10;

    void Start()
    {
        
    }

    void Update()
    {
        if (M1HP.fillAmount == 0)
        {
            Destroy(gameObject);
        }
    }

    public Image M1HP;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerWeapon")
        {
            M1HP.fillAmount -= 0.2f;
        }
    }
}
