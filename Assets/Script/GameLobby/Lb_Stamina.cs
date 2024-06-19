using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;


public class Lb_Stamina : MonoBehaviour,IPointerClickHandler
{
    public TextMeshProUGUI text;
    public RectTransform rectFill;
    public float FillX;

    private void Update()
    {
        var clampFill = Math.Clamp(FillX, 0f, 300f);
        text.text = clampFill.ToString();
    }
    //private void protoType1()
    //{
    //    text.text = FillX.ToString();
    //    var agi = Convert.ToInt32(text.text);
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        var damage = agi - 10;
    //        text.text = damage.ToString();
    //        var currentSize = rectFill.sizeDelta;
    //        var minusSize = currentSize.x - 10;
    //        rectFill.sizeDelta = new Vector2(minusSize, rectFill.sizeDelta.y);
    //    }
    //}

    public void OnPointerClick(PointerEventData eventData)
    {
        FillX -= 10;
        var currentFill = rectFill.sizeDelta;
        var minusFill = currentFill.x - 10;
        rectFill.sizeDelta = new Vector2(minusFill, rectFill.sizeDelta.y);
    }
}
