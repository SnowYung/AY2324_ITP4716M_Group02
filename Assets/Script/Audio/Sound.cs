using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    private AudioSource sound;
    private float preVolume;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        sound.volume = 0.5f;
        preVolume = sound.volume;
    }

    public void VolumeChanged(float newVolume)
    {
        //sound.volume = newVolume;
        AudioListener.volume = newVolume;
    }
}
