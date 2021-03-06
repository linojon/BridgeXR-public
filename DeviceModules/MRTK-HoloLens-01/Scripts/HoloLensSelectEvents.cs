﻿using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.Events;

public class HoloLensSelectEvents : MonoBehaviour, IInputHandler, IFocusable
{
    public UnityEvent OnTouch;
    public UnityEvent OnUnTouch;
    public UnityEvent OnSelect;
    public UnityEvent OnUnSelect;

    public void OnFocusEnter()
    {
        OnTouch.Invoke();
    }

    public void OnFocusExit()
    {
        OnUnTouch.Invoke();
    }

    public void OnInputDown(InputEventData eventData)
    {
        OnSelect.Invoke();
    }

    public void OnInputUp(InputEventData eventData)
    {
        OnUnSelect.Invoke();
    }
}
