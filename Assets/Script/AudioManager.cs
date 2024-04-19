using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    AudioSource audio;

    [SerializeField]
    AudioClip spandbyMusic;

    [SerializeField]
    AudioClip dialogueMusic;

    private void Start()
    {
        PlaySpandbyMusic();
    }

    public void PlaySpandbyMusic()
    {
        audio.clip = spandbyMusic;
        audio.Play();
    }

    public void PlayDialogueMusic()
    {
        audio.clip = dialogueMusic;
        audio.Play();
    }

    public void StopMusic()
    {
        audio.Stop();
    }
}
