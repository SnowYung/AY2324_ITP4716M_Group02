using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Language { English, Chinese }
public class GameManager : MonoBehaviour
{
    [SerializeField] StorySO[] storySos;
    int storyIndex;

    [SerializeField] StoryManager storyManager;


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
        if (storyIndex < storySos.Length)
        {
            storyManager.SetDialogue(storySos[storyIndex++]);
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
