using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    [SerializeField] GameObject hand;
    [SerializeField] GameObject nails;

    // Use this for initialization
    void Start ()
    {
    }

    // Update is called once per frame
    void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.C))
        {
            nails.GetComponent<NailScript>().GrowNails();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            SwipeManager.Instance.InvokeSwipeHappened(InputAction.Down);
        }
    }
}
