using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{

    [SerializeField] GameObject StoryPanelGO;
    [SerializeField] Text storyText;

    float startTime;
    [SerializeField] float speed = 1;

    private StorySO storySO;
    

    public void SetDialogue(StorySO storySO)
    {
        //Debug.Log("Set Dialog");
        storyText.text = "";
        this.storySO = storySO;
        startTime = Time.time;
    }

    void Update()
    {
        string dislogue = storySO.GetDialogue();
        storyText.text = dislogue.Substring(0, Mathf.Min((int)((Time.time - startTime) * speed), dislogue.Length));
    }

    public bool IsDialogueEnded()
    {
        return (int)((Time.time - startTime) * speed) > storySO.GetDialogue().Length;
    }

    public void EndDialogue()
    {
        Debug.Log("EndDialogue");
        startTime -= storySO.GetDialogue().Length / speed;
    }

    public void DisplayDialoguePanel()
    {
        StoryPanelGO.SetActive(true);
    }

    public void HideDialoguePanel()
    {
        StoryPanelGO.SetActive(false);
    }
}
