using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSlide : MonoBehaviour
{
    public AudioSource sound;
    public Slider slider;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //M1HP.fillAmount -= 0.2f;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //M1HP.fillAmount -= 0.2f;
        }
    }

    public void Audio()
    {
        sound.volume = slider.value;
    }
}
