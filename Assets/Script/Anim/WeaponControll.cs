using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControll : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

<<<<<<< Updated upstream
    void Update()
    {
=======
    


        private void Update()
        {
>>>>>>> Stashed changes
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Left Click");
        }

        if (Input.GetMouseButtonDown(1))
        {
            anim.SetTrigger("Right Click");
        }
        }
    }

