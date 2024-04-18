using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Language { English, Chinese }
public class GameManager : MonoBehaviour
{
    [SerializeField] DialogueSO[] dialogueSos;
    int dialogueIndex;

    [SerializeField] DialogueManager dialogueManager;


    private static Language language = Language.English;
    public static Language GetLanguage()
    {
        return language;
    }

    private void Start()
    {
        PlayNextDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayNextDialogue();
        }
    }

    void PlayNextDialogue()
    {
        if (dialogueIndex < dialogueSos.Length)
        {
            dialogueManager.SetDialogue(dialogueSos[dialogueIndex++]);
        }
    }

    public void SetEnglish()
    {
        language = Language.English;
    }

    public void SetChinese()
    {
        language = Language.Chinese;
    }
}
