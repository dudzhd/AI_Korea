using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    private int dialogueNumber = 0;
    public Dialogue[] dialogue;
    public static int SceneNumber = 0;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue[dialogueNumber]);
    }

    public void NextDialogue()
    {
        if (dialogueNumber == dialogue.Length - 1)
        {
            MoveToMiniGame();
            return;
        }
        dialogueNumber++;
        TriggerDialogue();
    }
    public void MoveToMiniGame()
    {
        switch (SceneNumber)
        {
            case 0:
                LoadingSceneController.LoadScene("First MiniGame Scene");
                ++SceneNumber;
                break;
            case 1:
                LoadingSceneController.LoadScene("Second MiniGame Scene");
                ++SceneNumber;
                break;
            case 2:
                SceneNumber = 0;
                LoadingSceneController.LoadScene("Intro");
                break;
            default:
                SceneNumber = 0;
                Debug.Log("Nonexsist");
                LoadingSceneController.LoadScene("Intro");
                break;
        }
    }
}
