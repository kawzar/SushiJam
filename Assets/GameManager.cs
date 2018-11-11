using System.Collections;
using System.Collections.Generic;
using RookBirdTools.Patterns;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : ScriptSingleton<GameManager>
{
    public float maxTime = 60.0f;
    public float currentTime = 0f;
    public int score;
    public bool isTimeRunning;

    [SerializeField]
    TextMeshProUGUI stopwatchText;

    [SerializeField]
    TextMeshProUGUI scorePointsText;

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
        isTimeRunning = true;
    }

    void Update ()
    {
        if (isTimeRunning)
        {
            currentTime += Time.deltaTime;
            stopwatchText.text = (maxTime - currentTime).ToString("0.00");

            if (currentTime >= maxTime)
            {
                stopwatchText.text = 0f.ToString("0.00");
                isTimeRunning = false;
            }
        }
    }
}
