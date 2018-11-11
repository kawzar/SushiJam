using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Global.Stats;

public class GameOverScreen : MyScreen
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        //GameManager.Instance.OnGameRestarted += Restart;
    }

    public void ShowGameOverScreen()
    {
        scoreText.text = GameStats.Instance.GetScore().ToString();
        Show();
    }
}