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
        if (PlayerHP.fillAmount == 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    
}
    public Image PlayerHP;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "M1Weapon")
        {
            PlayerHP.fillAmount -= 0.05f;
        }
    }
}
