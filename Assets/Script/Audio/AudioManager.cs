using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    AudioSource sound;

    [SerializeField]
    AudioClip spandbyMusic;

    [SerializeField]
    AudioClip settingMusic;

    [SerializeField]
    AudioClip dialogueMusic;

    private void Start()
    {
        PlaySpandbyMusic();
    }

    public void PlaySpandbyMusic()
    {
        sound.clip = spandbyMusic;
        sound.Play();
    }

    public void PlaySettingMusic()
    {
        sound.clip = settingMusic;
        sound.Play();
    }

    public void PlayDialogueMusic()
    {
        sound.clip = dialogueMusic;
        sound.Play();
    }

    public void StopMusic()
    {
        sound.Stop();
    }
}
