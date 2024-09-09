using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    private void Awake()
    {
        DialogueTrigger.SceneNumber = 0;

        TofindObject.findNumber = 0;
    }

    public void Start_Button()
    {
        LoadingSceneController.LoadScene("Main Scene");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
