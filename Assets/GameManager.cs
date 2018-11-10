using System.Collections;
using System.Collections.Generic;
using RookBirdTools.Patterns;
using UnityEngine;

public class GameManager : ScriptSingleton<GameManager>
{
    #region Fish Sprites
    [Header("Fish sprites")]
    [SerializeField]
    private Sprite shrimpSprite;

    [SerializeField]
    private Sprite crabSprite;

    [SerializeField]
    private Sprite salmonSprite;

    [SerializeField]
    private Sprite tunaSprite;
    #endregion

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
