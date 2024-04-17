using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Script", menuName = "SO/DialogueSO", order = 1)]
public class DialogueSO : ScriptableObject
{

    [SerializeField] string englishDialogue;
    [SerializeField] string chineseDialogue;

    public string GetDialogue()
    {
        switch (GameManager.GetLanguage())
        {
            case Language.English:
                return englishDialogue;
            case Language.Chinese:
                return chineseDialogue;
            default:
                return null;
        }
    }

}
