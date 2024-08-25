using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSceneController : MonoBehaviour
{
    static string nextScene;

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("Loading Scene");
    }

    private void Start()
    {
        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation aop = SceneManager.LoadSceneAsync(nextScene);
        aop.allowSceneActivation = false;

        while (!aop.isDone)
        {
            if (aop.progress >= 0.9f)
            {
                yield return new WaitForSeconds(0.3f);
                aop.allowSceneActivation = true;

                break;
            }
        }

        yield return null;
    }
}
