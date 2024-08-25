using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorView : MonoBehaviour
{
    public RectTransform transformView;

    private void Awake()
    {
        Init_Cursor();
    }

    private void Update()
    {
        Update_MousePosition();
    }

    public void Init_Cursor()
    {
        Cursor.visible = false;

        if (transformView.GetComponent<Graphic>()) transformView.GetComponent<Graphic>().raycastTarget = false;
    }

    private void Update_MousePosition()
    {
        Vector2 mousePos = Input.mousePosition;
        transformView.position = mousePos;

        float tmp_cursorPosX = transformView.position.x;
        float tmp_cursorPosY = transformView.position.y;

        float min_width = 0;
        float max_width = Screen.width;
        float min_height = 0;
        float max_height = Screen.height;
        int padding = 20;

        tmp_cursorPosX = Mathf.Clamp(tmp_cursorPosX, min_width + padding, max_width - padding);
        tmp_cursorPosY = Mathf.Clamp(tmp_cursorPosY, min_height + padding, max_height - padding);

        transformView.position = new Vector2(tmp_cursorPosX, tmp_cursorPosY);
    }
}
