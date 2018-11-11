using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Global.Stats;
using UnityEngine.UI;

public class GameOverScreen : MyScreen
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField]
    private ScorePlates scorePlates;

    public Button[] buttons;
    private void Start()
    {
        //GameManager.Instance.OnGameRestarted += Restart;
    }

    public void ShowGameOverScreen()
    {
        scoreText.text = GameStats.Instance.GetScore().ToString();
        scorePlates.ShowScorePlates();
        Show();

        foreach (Button b in buttons)
        {
            b.enabled = true;
        }
    }
}