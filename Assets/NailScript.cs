using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NailScript : MonoBehaviour
{

    [SerializeField] GameObject maxPosition;
    public int rollCount = 5;
    public float animationDuration = 0.25f;

    float initialPosition = 0f;
    int iteration = 0;


    public void GrowNails()
    {
        if (iteration < rollCount)
        {
            float delta = (maxPosition.transform.localPosition.y - initialPosition) / rollCount;
            iteration++;

            transform.DOLocalMoveY(initialPosition + delta * iteration, animationDuration);
        }
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
