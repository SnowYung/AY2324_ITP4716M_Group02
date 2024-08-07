using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Language { English, Chinese }
public class UIManager : MonoBehaviour
{
    [SerializeField] StorySO[] storySos;
    int storyIndex;

    [SerializeField] StoryManager storyManager;

    public GameObject goButton;

    private static Language language = Language.English;

    public static Language GetLanguage()
    {
        return language;
    }

    private void Start()
    {
        //PlayNextDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(storyManager.IsDialogueEnded())
            {
                PlayNextDialogue();
            }
            else
            {
                storyManager.EndDialogue();
            }
        }
    }

    public void PlayNextDialogue()
    {
        //Debug.Log("PlayerDialogue");
        if (storyIndex < storySos.Length)
        {
            storyManager.SetDialogue(storySos[storyIndex++]);
            goButton.SetActive(false);
        }
        else
        {
            goButton.SetActive(true);
        }
    }

    public void RestartDialogue()
    {
        storyIndex = 0;
        //storyManager.SetDialogue(storySos[0]);
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
