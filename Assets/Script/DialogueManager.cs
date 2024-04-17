using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    [SerializeField] GameObject dialoguePanelGO;
    [SerializeField] Text dialogueText;

    float startTime;
    [SerializeField] float speed = 1;

    private DialogueSO dialogueSO;


    public void SetDialogue(DialogueSO dialogueSO)
    {
        dialogueText.text = "";
        this.dialogueSO = dialogueSO;
        startTime = Time.time;
    }

    //void Update()
    //{
    //    string dislogue = dialogueSO.GetDialogue();
    //    dialogueText.text = dislogue.Substring(0, Mathf.Min((int)((Time.time - startTime) * speed), dislogue.Length));
    //}

    public void DisplayDialoguePanel()
    {
        dialoguePanelGO.SetActive(true);
    }

    public void HideDialoguePanel()
    {
        dialoguePanelGO.SetActive(false);
    }
}
