using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lb_Buttons : MonoBehaviour
{
    public TextMeshProUGUI Text;
    [SerializeField]
    private float Stamina = 300;
    private void Update()
    {
        var clampStm = Math.Clamp(Stamina, 0f, 300f);
        Text.text = clampStm.ToString();
    }
    public void AddStamina()
    {
        var CurrentStm = Stamina;
        Stamina = Math.Clamp(CurrentStm + 10,0f,300f);
        Debug.Log(Stamina);
    }
    public void RemoveStamina() 
    {
        var CurrentStm = Stamina;
        Stamina = Math.Clamp(CurrentStm - 10, 0f, 300f);
        Debug.Log(Stamina);
    }
    public void Game()
    {
        if (Stamina > 0)
        {
            //SceneManager.LoadScene(0);
        }
    }
}
