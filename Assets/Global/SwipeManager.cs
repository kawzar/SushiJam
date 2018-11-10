using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeManager : MonoBehaviour
{
    public static SwipeManager Instance;

    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered

    public delegate void SwipeHappened(InputAction direction);
    public static event SwipeHappened OnSwipeHappened;
    
    public delegate void FingerUp();
    public static event FingerUp OnFingerUp;

    private bool alreadyTriggeredThisSwipe;

    public float Horizontal { private set; get; }
    public float Vertical { private set; get; }

    private float initialTime;
    private float maxTime = .2f;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        dragDistance = Screen.height * 5 / 100; //dragDistance is 15% height of the screen
    }

    void Update()
    {
        if(Input.touchCount != 1) // user is touching the screen with a single touch
        {
            Horizontal = 0;
            Vertical = 0;

            //if(Input.touchCount == 4)
            //{
            //    OnSwipeHappened?.Invoke(InputAction.Debug);
            //}
            return;
        }

        Touch touch = Input.GetTouch(0); // get the touch

        switch(touch.phase)
        {
            case TouchPhase.Began:
                fp = touch.position;
                lp = touch.position;
                alreadyTriggeredThisSwipe = false;

                initialTime = Time.time;
                break;

            case TouchPhase.Moved:
                lp = touch.position;

                //Check if drag distance is greater than 20% of the screen height
                if(Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {
                    //It's a drag 
                    //check if the drag is vertical or horizontal
                    if(Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                    {
                        if((lp.x > fp.x))
                        {
                            if(!alreadyTriggeredThisSwipe)
                            {
                                //Right swipe                            
                                print("Swipe right");
                                OnSwipeHappened?.Invoke(InputAction.Right);
                                alreadyTriggeredThisSwipe = true;
                            }
                        }
                        else
                        {
                            if(!alreadyTriggeredThisSwipe)
                            {
                                //Left swipe
                                print("Left");
                                alreadyTriggeredThisSwipe = true;
                                OnSwipeHappened?.Invoke(InputAction.Left);
                            }
                        }

                        Horizontal = Mathf.Clamp(lp.x - fp.x, -1, 1);
                    }
                    else
                    {   //the vertical movement is greater than the horizontal movement
                        if(lp.y > fp.y)  //If the movement was up
                        {   //Up swipe
                            if(!alreadyTriggeredThisSwipe)
                            {
                                print("Up");
                                OnSwipeHappened?.Invoke(InputAction.Up);
                                alreadyTriggeredThisSwipe = true;
                            }
                        }
                        else
                        {   //Down swipe
                            if(!alreadyTriggeredThisSwipe)
                            {
                                print("DOWN!");
                                OnSwipeHappened?.Invoke(InputAction.Down);
                                alreadyTriggeredThisSwipe = true;
                            }
                        }

                        Vertical = Mathf.Clamp(lp.y - fp.y, -1, 1);
                    }
                }
                break;

            case TouchPhase.Stationary:
                if(Time.time - initialTime > maxTime)
                {
                    if(!alreadyTriggeredThisSwipe)
                    {
                        OnSwipeHappened?.Invoke(InputAction.Pressed);
                        Horizontal = fp.x > Screen.width / 2 ? 1 : -1;
                        alreadyTriggeredThisSwipe = true;
                    }                    
                }
                break;

            case TouchPhase.Ended:
                if(Mathf.Abs(lp.x - fp.x) < dragDistance || Mathf.Abs(lp.y - fp.y) < dragDistance)
                {
                    if(Time.time - initialTime < maxTime)
                    {
                        if(!alreadyTriggeredThisSwipe)
                        {
                            //print("TAP");
                            alreadyTriggeredThisSwipe = true;
                            OnSwipeHappened?.Invoke(InputAction.Tap);

                        }
                    }
                }

                OnFingerUp?.Invoke();

                Horizontal = 0;
                Vertical = 0;
                break;
        }

    }
}
