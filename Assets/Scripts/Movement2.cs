using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement2 : MonoBehaviour
{
    public int movementSpeed = 20;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    CharacterController charControl;

    private void Start()
    {
        charControl = GetComponent<CharacterController>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (charControl.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= movementSpeed;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        charControl.Move(moveDirection * Time.deltaTime);
    }
}
