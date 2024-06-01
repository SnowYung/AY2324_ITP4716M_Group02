using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSound : MonoBehaviour
{
    public AudioClip LeftClick;
    public AudioClip RightClick;

    AudioSource audio;

    private float preVolume;


    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.volume = 1;
    }

    void PlayWeaponCut()
    {
        audio.volume = 1f;
        audio.PlayOneShot(LeftClick);
    }

    void PlayWeaponPoke()
    {
        audio.volume = 0.3f;
        audio.PlayOneShot(RightClick);
    }
}
