using UnityEngine;
using UnityEngine.UI;

public class NumText : MonoBehaviour
{
    private static Text numText;

    void Start()
    {
        numText = GetComponent<Text>();
    }

    void Update()
    {
        EnemyAI[] enemies = FindObjectsOfType<EnemyAI>();
        numText.text = enemies.Length.ToString();
    }
}
