using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSlide : MonoBehaviour
{
    [SerializeField]
    private GameObject soundSlide;
    private float interval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdjustSpawnInterval(float interval)
    {
        this.interval = interval;
    }
}
