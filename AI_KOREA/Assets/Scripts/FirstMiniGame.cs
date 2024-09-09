using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstMiniGame : MonoBehaviour
{
    public GameObject[] randomgameObjects;
    public GameObject[] toFindObject;
    private int randomNum;
    public GameObject Objects;
    public GameObject introPanel;

    float x;
    float y;

    Vector3 spawnPosition;

    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            x = Random.Range(100, Screen.width - 100);
            y = Random.Range(100, Screen.height - 100);

            spawnPosition = new Vector2(x, y);

            Instantiate(toFindObject[i], spawnPosition, Quaternion.identity, Objects.transform);
        }

        for (int i = 0; i < 30; i++)
        {
            randomNum = Random.Range(0, 5);

            x = Random.Range(100, Screen.width - 100);
            y = Random.Range(100, Screen.height - 100);

            spawnPosition = new Vector2(x, y);

            Instantiate(randomgameObjects[randomNum], spawnPosition, Quaternion.identity, Objects.transform);
        }
    }

    public void Clear()
    {
        Invoke(nameof(SceneChanger), 2f);
    }

    void SceneChanger()
    {
        LoadingSceneController.LoadScene("Second Main Scene");
    }

    public void CloseIntro()
    {
        introPanel.SetActive(false);
    }
}
