using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NailScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] waypoints;

    public float animationDuration = 0.25f;

    float initialPosition = 0f;
    int iteration = 0;


    public void GrowNails()
    {
        if (iteration < waypoints.Length - 1)
        {
            iteration++;
            transform.DOMove(waypoints[iteration].transform.position, animationDuration);
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
