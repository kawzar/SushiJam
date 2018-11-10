using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum InputAction
{
    Up,
    Down,
    Left,
    Right,
    FingerUp,
    Tap,
    Pressed,
    Debug
}

public class InputManager : MonoBehaviour
{
    public static InputManager Instance 
    {
        get 
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<InputManager>();
            }
            return _instance;
        }

        set 
        {
            _instance = value;
        }
    }

    private static InputManager _instance;

    public KeyCode InteractKey = KeyCode.E;
    
    [HideInInspector]
    public float Horizontal;

    [HideInInspector]
    public float Vertical;

    public delegate void InputHappened(InputAction direction);
    public static event InputHappened OnDirectionalInputHappened;

    public bool Interact { private set; get; }

    private void InvokeDirectionInput(InputAction direction) => OnDirectionalInputHappened?.Invoke(direction);

    private float startTapTime;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            transform.SetParent(null);
            DontDestroyOnLoad(gameObject);
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        SwipeManager.OnSwipeHappened += InvokeDirectionInput;
        SwipeManager.OnFingerUp += InvokeFingerUp;
    }

    public void Reset()
    {
        Horizontal = 0;
        Vertical = 0;
    }

    private void OnDestroy()
    {
        SwipeManager.OnSwipeHappened -= InvokeDirectionInput;
        
        SwipeManager.OnFingerUp -= InvokeFingerUp;
    }

    private void InvokeFingerUp()
    {
        InvokeDirectionInput(InputAction.FingerUp);
    }

    void Update ()
    {
        Horizontal = Input.GetAxis("Horizontal") + SwipeManager.Instance.Horizontal; 
        Vertical = Input.GetAxis("Vertical") + SwipeManager.Instance.Vertical;

#if UNITY_EDITOR
        //if(Input.GetKeyDown(KeyCode.Equals))
        //    OnDirectionalInputHappened?.Invoke(InputAction.Debug);

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Island 1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Surfing Level 1");
        }

#endif
        if (Input.GetButtonDown("Horizontal"))
        {
            if(Input.GetAxisRaw("Horizontal") < 0)
            {
                OnDirectionalInputHappened?.Invoke(InputAction.Left);
            }
            else if(Input.GetAxisRaw("Horizontal") > 0)
            {
                OnDirectionalInputHappened?.Invoke(InputAction.Right);
            }
        }

        if(Input.GetKeyDown(InteractKey) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            startTapTime = Time.time;
        }


        if(Input.GetKeyUp(InteractKey) || Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.Return))
        {
            if(Time.time - startTapTime < .25f)
            {
                OnDirectionalInputHappened?.Invoke(InputAction.Tap);
            }
            OnDirectionalInputHappened?.Invoke(InputAction.FingerUp);
        }

        if(Input.GetButtonDown("Vertical"))
        {
            if(Input.GetAxisRaw("Vertical") < 0)
            {
                OnDirectionalInputHappened?.Invoke(InputAction.Down);
            }
            else if(Input.GetAxisRaw("Vertical") > 0)
            {
                OnDirectionalInputHappened?.Invoke(InputAction.Up);
            }
        }

        if(Input.GetButtonUp("Horizontal") || Input.GetButtonUp("Vertical"))
        {
            InvokeDirectionInput(InputAction.FingerUp);
        }
    }

    private void StopListening()
    {
        gameObject.SetActive(false);
    }
}
