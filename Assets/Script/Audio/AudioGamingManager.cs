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
    AudioClip enemyEffects;

    [SerializeField]
    GameObject enemy;

    void Start()
    {
        PlayBackGroundMusic();
        PlayEnemyEffect();
    }

    public void PlayBackGroundMusic()
    {
        Audio.clip = backgroundMusic;
        Audio.Play();
    }

    public void PlayEnemyEffect()
    {
        //GameObject.Find("Enemy");
        //if ()
        //{
        //    Audio.clip = enemyEffects;
        //    Audio.Play();
        //}
    }

    private void Enemy(Vector3 pos)
    {
        Instantiate(enemy, pos, Quaternion.identity);
    }

}

