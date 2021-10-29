using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging;

    // Metódo que representa el Drag
    private void OnMouseDown()
    {
        isDragging = true;
    }

    // Metódo que representa el Drop
    private void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mouseUp = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mouseUp);
        }
    }
}
