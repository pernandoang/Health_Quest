using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lb_Buttons : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private float Stamina;
    public float StmProp
    {
        get { return Stamina; }
        set { Stamina = value; }
    }

    private void Update()
    {
        var clampStm = Math.Clamp(StmProp, 0f, 300f);
        Text.text = clampStm.ToString();
    }
    public void AddStamina(int jumlah)
    {
        var CurrentStm = StmProp;
        StmProp = Math.Clamp(CurrentStm + jumlah,0f,300f);
        Debug.Log(StmProp);
    }
    public void RemoveStamina() 
    {
        var CurrentStm = StmProp;
        StmProp = Math.Clamp(CurrentStm - 10, 0f, 300f);
        Debug.Log(StmProp);
    }
    public void Game()
    {
        var currentStm = StmProp;
        if (currentStm > 9)
        {
            Debug.Log("Pindah scene");
        }
        else
        {
            Debug.Log("Stamina Kurang");
        }
    }
}
