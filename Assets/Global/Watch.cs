using System;
using Assets.Global;
using Global.Stats;
using RookBirdTools.Patterns;
using TMPro;
using UnityEngine;

public class Watch : ScriptSingleton<Watch>
{
    [SerializeField]
    TextMeshProUGUI stopwatchText;

    [SerializeField]
    TextMeshProUGUI scorePointsText;
    private Stopwatch stopwatch;

    private bool init;


    public void Init(Action onStop)
    {
        stopwatch = new Stopwatch();
        stopwatch.OnStop(onStop);
        stopwatch.Start();
        init = true;
    }

    void Update()
    {
        if (init)
        {
            stopwatch.UpdateClock(Time.deltaTime);
            stopwatchText.text = stopwatch.RemainingTime.ToString("0.00");

            scorePointsText.text = GameStats.Instance.GetScore().ToString();
        }

    }
}