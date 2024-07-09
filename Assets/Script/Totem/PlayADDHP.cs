using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayADDHP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            GameObject.Find("FPSController").GetComponent<SrPlayerHP>().ADDHP();
            Destroy(gameObject);
            GameObject.Find("Generrate").GetComponent<GenTotem>().Generrate();
        }
    }
}
