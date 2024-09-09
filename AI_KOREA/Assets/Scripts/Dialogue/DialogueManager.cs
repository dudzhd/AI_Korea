using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Image backgroundImage;

    private bool IsCoroutineDone = true;

    public Queue<string> sentences;

    void Awake()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        if (dialogue.BackgroundImage != null)
        {
            backgroundImage.sprite = dialogue.BackgroundImage;
        }

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0) 
        { 
            FindObjectOfType<DialogueTrigger>().NextDialogue();

            return;
        }
        
        if (IsCoroutineDone == false)
        {
            StopAllCoroutines();
            dialogueText.text = sentences.Dequeue();

            IsCoroutineDone = true;
        }
        else
        {   
            string sentence = sentences.Peek();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
        }
    }

    IEnumerator TypeSentence(string sentencesArray)
    {
        IsCoroutineDone = false;

        dialogueText.text = "";
        foreach (char letter in sentencesArray.ToCharArray())
        {
            dialogueText.text += letter;

            yield return new WaitForSeconds(0.03f);

            yield return null;
        }

        sentences.Dequeue();
        IsCoroutineDone = true;
    }
}
