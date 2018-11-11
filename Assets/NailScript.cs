using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using RookBirdTools.MoreTools;
using RookBirdTools.Patterns;

public class NailScript : ScriptSingleton<NailScript>
{
    [SerializeField]
    GameObject[] waypoints;

    public float animationDuration = 0.25f;

    float initialPosition = 0f;
    int iteration = 0;
	private Action _onFever;
	private Action _onNormal;
	

	public void OnFever(Action onFever)
	{
		_onFever = onFever;
	}

	public void OnNormal(Action onNormal)
	{
		_onNormal = onNormal;
	}

    public void GrowNails()
    {
        if (iteration < waypoints.Length - 1)
        {
            iteration++;
            transform.DOLocalMove(waypoints[iteration].transform.localPosition, animationDuration);
        }
        else
        {
	        SacredMusic.Instance.PlayLoopTemaFever();
	        _onFever.Invoke();
	        TimeStuff.DoAfter(() =>
	        {
		        SacredMusic.Instance.StopLoopTemaFever();
		        _onNormal.Invoke();
	        },50);
        }
    }


	public void ToBorn()
	{
		iteration = 0;
		transform.DOLocalMove(waypoints[iteration].transform.localPosition, animationDuration);
	}

	// Use this for initialization
	void Start () 
    {
        initialPosition = transform.localPosition.y;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
