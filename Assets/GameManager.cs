using System.Collections;
using System.Collections.Generic;
using RookBirdTools.Patterns;
using UnityEngine;

public class GameManager : ScriptSingleton<GameManager>
{
    #region Fish Sprites
    [Header("Fish prefab")]
    public GameObject shrimpPrefab;
    public GameObject crabPrefab;
    public GameObject salmonPrefab;
    public GameObject tunaPrefab;
    #endregion

	public Transform RecipiesStartPoint; 

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
