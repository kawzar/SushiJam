﻿using System.Collections;
using System.Collections.Generic;
using Assets.Global;
using Global.Stats;
using RookBirdTools.Patterns;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : ScriptSingleton<GameManager>
{
    
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
	
	[SerializeField] public GameObject nails;
    public GameOverScreen gameOverScreen;
    public StartScreen StartScreen;

    public Animator bearAnimator;
    [SerializeField] GameObject bearImageGameObject;

    private new void Awake()
    {
        base.Awake();
        gameOverScreen = FindObjectOfType<GameOverScreen>();
        StartScreen = FindObjectOfType<StartScreen>();

        bearAnimator = bearImageGameObject.GetComponent<Animator>();
    }
}
