using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Menu_MouseEnter : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public RectTransform[] rect;
    public Vector2[] startPosition;
    public Vector2[] endPosition;

    public void OnPointerEnter(PointerEventData eventData)
    {
        rect[0].position = endPosition[0];
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rect[0].position = startPosition[0];
    }
}
