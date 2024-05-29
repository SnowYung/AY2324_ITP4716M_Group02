using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    public AudioClip DoorOpen;
    public AudioClip DoorClose;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void PlayOpenSound()
    {
        audio.PlayOneShot(DoorOpen);
    }

    void PlayCloseSound()
    {
        audio.PlayOneShot(DoorClose);
    }
}
