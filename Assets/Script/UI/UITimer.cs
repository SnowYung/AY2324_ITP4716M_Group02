using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour
{
    [SerializeField]
    float time = 5f;

    public GameObject nextButton;

    Text timer;

    private void OnEnable()
    {
        time = 5f;
        nextButton.SetActive(false);
        timer = GetComponent<Text>();
    }

    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            timer.text = time.ToString("0.0");
        }
        else if (!nextButton.activeSelf)
        {
            timer.gameObject.SetActive(false);
            nextButton.SetActive(true);
        }
    }
}
