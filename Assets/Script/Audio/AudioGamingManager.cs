using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGamingManager : MonoBehaviour
{
    [SerializeField]
    AudioSource Audio;

    [SerializeField]
    AudioClip backgroundMusic;

    [SerializeField]
    AudioClip M1;

    void Start()
    {
        PlayBackGroundMusic();
    }

    public void PlayBackGroundMusic()
    {
        Audio.clip = backgroundMusic;
        Audio.Play();
    }


}

