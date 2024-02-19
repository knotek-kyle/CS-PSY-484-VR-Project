using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class XRControllerEvent : MonoBehaviour
{
    public InputActionProperty button;
    public UnityEvent onPress;
    public UnityEvent onRelease;

    void Update()
    {
        if (button.action.WasPressedThisFrame())
        {
            onPress.Invoke();
        }

        if (button.action.WasReleasedThisFrame())
        {
            onRelease.Invoke();
        }
    }
}
