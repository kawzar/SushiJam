using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HandMovement : MonoBehaviour
{
    [SerializeField]
    GameObject waypoint1;

    [SerializeField]
    GameObject waypoint2;

    [SerializeField]
    GameObject waypoint3;


    public void MoveHand()
    {
        var sequence = DOTween.Sequence()
            .Append(transform.DOMove(waypoint1.transform.position, 0.25f).SetEase(Ease.Linear))
            .Append(transform.DOMove(waypoint2.transform.position, 0.25f).SetEase(Ease.Linear))
            .Append(transform.DOMove(waypoint3.transform.position, 0.25f).SetEase(Ease.Linear));

        sequence.Play();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
