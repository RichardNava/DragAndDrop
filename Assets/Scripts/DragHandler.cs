using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject itemDragging;

    public Vector2 startPos;
    private Transform startParent;
    private Transform dragParent;
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;   
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Estoy en Begin");
        itemDragging = gameObject;

        startPos = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Estoy en Drag");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Estoy en End");
        itemDragging = null;

        if (transform.parent == dragParent)
        {
            transform.position = startPos;
            transform.SetParent(startParent);
        }
    }


}
