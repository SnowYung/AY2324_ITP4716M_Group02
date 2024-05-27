using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumText : MonoBehaviour
{
    private static int num = 10;
    private static Text numText;

    void Start()
    {
        numText = GetComponent<Text>();
        UpdateNumVisual();
    }

    private static void UpdateNumVisual()
    {
        numText.text = num.ToString() + " ";
    }

    public static void UpdateNum(int value)
    {
        num -= value;
        UpdateNumVisual();
    }

    public static void ResetNum()
    {
        num = 10;
        UpdateNumVisual();
    }
}
