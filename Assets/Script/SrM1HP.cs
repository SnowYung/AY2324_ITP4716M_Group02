using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SrM1HP : MonoBehaviour
{
    //int GameOver=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //if (M1HP.fillAmount == 0)
    //    //{
    //    //    Destroy(gameObject);
    //    //    GameOver--;
    //    //    Debug.Log(GameOver);
    //    //}
    //    if (GameOver == 10)
    //    {
    //        Application.Quit();
    //    }
    //}
    public Image M1HP;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerWeapon")
        {
            M1HP.fillAmount -= 0.2f;
        }
    }
}
