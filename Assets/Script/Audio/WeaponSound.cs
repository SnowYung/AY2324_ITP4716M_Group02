using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSound : MonoBehaviour
{
    public AudioClip LeftClick;
    public AudioClip RightClick;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void PlayWeaponCut()
    {
        audio.PlayOneShot(LeftClick);
    }

    void PlayWeaponPoke()
    {
        audio.PlayOneShot(RightClick);
    }
}
