using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{

    private bool isDragging;

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
//Reference
// https://oxmond.com/how-to-drag-and-drop-a-2d-object/
// https://www.youtube.com/watch?v=55TBhlOt_U8&t=15s&ab_channel=OXMONDTutorials
