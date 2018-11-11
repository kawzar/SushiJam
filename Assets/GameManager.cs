using System.Collections;
using System.Collections.Generic;
using RookBirdTools.Patterns;
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
       
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
