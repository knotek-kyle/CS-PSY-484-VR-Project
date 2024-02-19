using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DelayedEvent : MonoBehaviour
{
    public float waitTime;
    public UnityEvent onAction;

    public void CallEvent()
    {
        Invoke(nameof(InvokeEvent), waitTime);
    }

    void InvokeEvent()
    {
        onAction.Invoke();
    }
}
