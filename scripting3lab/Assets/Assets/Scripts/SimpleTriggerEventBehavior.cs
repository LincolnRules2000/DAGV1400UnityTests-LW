using System;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEvent;
    public UnityEvent jumpEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpEvent.Invoke();
        }
    }
}
