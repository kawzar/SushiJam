using System.Collections;
using System.Collections.Generic;
using Assets.Global;
using Global.Stats;
using RookBirdTools.Patterns;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : ScriptSingleton<GameManager>
{
    public int score;

    [SerializeField]
    TextMeshProUGUI stopwatchText;

    [SerializeField]
    TextMeshProUGUI scorePointsText;

    private Stopwatch stopwatch;

    #region Fish Sprites
    [Header("Fish recipe images")]
    public Image shrimpRecipeImg;
    public Image crabRecipeImg;
    public Image salmonRecipeImg;
    public Image tunaRecipeImg;
    #endregion
	
	#region Fishs

	[Header("Fish sprites")] 
	public SpriteRenderer shrimpImg;
	public SpriteRenderer salmonImg;
	public SpriteRenderer crabImg;
	public SpriteRenderer tunaImg;

	public Transform StartPoint;
	public Transform DestinyPoint;
	public Transform HitPoint;

    #endregion

    private void Start()
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();
    }

    void Update ()
    {
        stopwatch.UpdateClock(Time.deltaTime);
        stopwatchText.text = stopwatch.RemainingTime.ToString("0.00");

        scorePointsText.text = GameStats.Instance.GetScore().ToString();
    }
}
