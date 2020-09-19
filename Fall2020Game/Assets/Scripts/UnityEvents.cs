using System;
using UnityEngine;
using UnityEngine.Events;

public class UnityEvents : MonoBehaviour
{
    public UnityEvent myUnityEvent;

    public void OnTriggerEnter(Collider other)
    {
        myUnityEvent.Invoke();
    }
}
