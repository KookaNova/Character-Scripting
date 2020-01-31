﻿using UnityEngine;
using UnityEngine.Events;

public class CharacterHandler : MonoBehaviour
{
    public float jumpSpeed = 10f, gravity = 5f;

    public CharacterController Controller;
    private Vector3 _position;

    public UnityEvent OnStart, onUpdateEvent;
    
    void Start()
    {
        Controller = GetComponent<CharacterController>();
        OnStart.Invoke();
    }
    
    void Update()
    {
        onUpdateEvent.Invoke();

        _position.y -= gravity;

        if (Controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            _position.y = jumpSpeed;
        }

        Controller.Move(_position * Time.deltaTime);
    }
}
