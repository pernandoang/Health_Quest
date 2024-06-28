using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lb_ToKitchen : MonoBehaviour
{
    public void ToKitchen(int number)
    {
        SceneManager.LoadScene(number);
    }
}
