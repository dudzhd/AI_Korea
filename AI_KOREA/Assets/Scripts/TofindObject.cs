using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TofindObject : MonoBehaviour
{
    public static int findNumber;
    public GameObject clearText;

    public void FindObject()
    {
        ++findNumber;

        if (findNumber == 3)
        {
            clearText.SetActive(true);

            FindObjectOfType<FirstMiniGame>().Clear();
        }

        Destroy(gameObject);
    }
}
