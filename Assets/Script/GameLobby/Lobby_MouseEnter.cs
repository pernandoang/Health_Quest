using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Lobby_MouseEnter : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public Image[] img;
    public Color setColor;
    public Color EndColor;

    public void OnPointerEnter(PointerEventData eventData)
    {
        img[0].color = setColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        img[0].color = EndColor;
    }
}
