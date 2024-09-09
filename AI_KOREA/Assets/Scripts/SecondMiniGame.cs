using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondMiniGame : MonoBehaviour
{
    public GameObject introPanel;
    CircleCollider2D circleCollider2D;
    public GameObject clearText;

    private void Awake()
    {
        circleCollider2D = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            clearText.SetActive(true);

            Invoke(nameof(SceneChanger), 2f);
        }
    }

    void SceneChanger()
    {
        LoadingSceneController.LoadScene("Third Main Scene");
    }

    public void CloseIntro()
    {
        introPanel.SetActive(false);
    }
}
