using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITimer : MonoBehaviour
{
    [SerializeField]
    float time = 5f;

    public GameObject nextButton;

    private void OnEnable()
    {
        time = 5f;
        nextButton.SetActive(false);
    }

    void Update()
    {
        if (time > 0)
            time -= Time.deltaTime;
        else if (!nextButton.activeSelf)
            nextButton.SetActive(true);
    }
}
