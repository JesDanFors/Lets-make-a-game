using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement2 : MonoBehaviour
{
    public int movementSpeed = 20;
    public float gravity = 20.0f;
    public int blinkDistance = 5;
    private Vector3 _moveDirection = Vector3.zero;
    CharacterController _charControl;

    private void Start()
    {
        _charControl = GetComponent<CharacterController>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (_charControl.isGrounded)
        {
            _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            _moveDirection *= movementSpeed;
        }

        //general movement
        _moveDirection.y -= gravity * Time.deltaTime;
        _charControl.Move(_moveDirection * Time.deltaTime);
        
        //Dash ability
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _charControl.transform.Translate(_moveDirection*Time.deltaTime * blinkDistance);
        }
        
    }
}
