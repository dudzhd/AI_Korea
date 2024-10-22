using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<DialogueTrigger>().TriggerDialogue();
    }

    void Update()
    {
        if(Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape))
        FindObjectOfType<DialogueManager>().DisplayNextSentence();
    }
}
