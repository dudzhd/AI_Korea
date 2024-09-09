using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restarter : MonoBehaviour
{
    public GameObject restartBtn;
    public bool restartBtnIsOn;

    public static Restarter instance;

    public static Restarter Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Restarter();
            }

            return instance;
        }
    }

    private void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!restartBtnIsOn)
            {
                restartBtnIsOn = true;
                restartBtn.SetActive(true);
            }
            else
            {
                restartBtnIsOn = false;
                restartBtn.SetActive(false);
            }
        }
    }

    public void ResetBtn()
    {
        restartBtnIsOn = false;
        restartBtn.SetActive(false);
        LoadingSceneController.LoadScene("Intro");
    }
}
