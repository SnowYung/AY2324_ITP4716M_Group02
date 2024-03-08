using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControll : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("Open");
        }
    }
    private  void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("Close");
        }
    }
}
