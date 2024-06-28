using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kc_PanelControl : MonoBehaviour
{
    public void SetActivePanel(GameObject panel)
    {
        panel.SetActive(true);
    }
    public void SetNonActivePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
}
