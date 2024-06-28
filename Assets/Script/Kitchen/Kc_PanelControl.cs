using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kc_PanelControl : MonoBehaviour
{
    private Lb_Buttons lobbystm;
    public void TambahStamina()
    {
        lobbystm = new();
        lobbystm.AddStamina();
        Debug.Log(lobbystm.StmProp);
    }
    public void SetActivePanel(GameObject panel)
    {
        panel.SetActive(true);
    }
    public void SetNonActivePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
}
