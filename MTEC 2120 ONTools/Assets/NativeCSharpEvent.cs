using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class NativeCSharpEvent : MonoBehaviour
{
    public delegate void MyPingEvent();
    public static event MyPingEvent OnPing;

    // Start is called before the first frame update
    void Start()
    {
        OnPing += Ping; // Add Listener, calls Ping whenever OnPing is invoked
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && OnPing != null)
        {
            OnPing(); //Broadcast
        }
    }
}
