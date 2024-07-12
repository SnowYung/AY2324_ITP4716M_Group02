using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControll : MonoBehaviour
{

    public Animator anim;

    public AudioClip DoorOpen;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("isOpen", true);
            audio.PlayOneShot(DoorOpen);
            //Debug.Log(other.gameObject.name+" Open " + Time.time);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("isOpen", false);
            //Debug.Log("Close " + Time.time);
        }
    }
}
