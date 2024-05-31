using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControll : MonoBehaviour
{

    private Animator anim;

    public AudioClip DoorOpen;

    AudioSource audio;

    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("Open");
            audio.PlayOneShot(DoorOpen);
            //Debug.Log(other.gameObject.name+" Open " + Time.time);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("Close");
            //Debug.Log("Close " + Time.time);
        }
    }
}
