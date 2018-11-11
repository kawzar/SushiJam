using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Global.Stats;

public class StartScreen : MyScreen
{
    public void HideStartScreen()
    {
        Hid += Disable;
        Hide();

    }

    private void Disable()
    {
        print("DISABLE");
        gameObject.SetActive(false);
       
    }

    private void OnDestroy()
    {
        Hid -= Disable;
    }
}