using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SrPlayerHP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHP.fillAmount  < 0.1)
        {
            Reset();
        }
    
}
    public Image PlayerHP;
    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "M1Weapon")
    //    {
    //        PlayerHP.fillAmount -= 0.05f;
    //        //Debug.Log("HP reduced");
    //    }
    //}

    public static void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameObject.Find("Enermys").GetComponent<updataNum>().ResetMark();
    }

    public void GetDamage(float damage)
    {
        PlayerHP.fillAmount -= damage;
    }
}
