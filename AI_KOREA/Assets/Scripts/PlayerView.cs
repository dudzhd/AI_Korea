using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public Transform playerTransform;
    public RectTransform transformView;

    void Start()
    {
        
    }

    void Update()
    {
        transformView.position = Camera.main.WorldToScreenPoint(playerTransform.position);
    }
}
