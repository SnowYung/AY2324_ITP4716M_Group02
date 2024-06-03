using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumText : MonoBehaviour
{
    private static int Num;
    private static Text numText;

    void Start()
    {
        int Num = GenerrateEnemy.GetNumOfEnemy();
        numText = GetComponent<Text>();
        UpdateNumVisual();
    }

    private static void UpdateNumVisual()
    {
        numText.text = Num.ToString() + " ";
    }

    public static void UpdateNum(int value)
    {
        Num -= value;
        UpdateNumVisual();
    }

    public static void ResetNum()
    {
        Num = 10;
        UpdateNumVisual();
    }
}
