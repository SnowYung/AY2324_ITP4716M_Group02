using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SrPlayerHP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Image PlayerHP;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "M1Weapon")
        {
            PlayerHP.fillAmount -= 0.1f;
        }
    }
}
