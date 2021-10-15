using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public int movementSpeed = 20;
    public float gravity = 20.0f;
    public int blinkDistance = 5;
    private Vector3 _moveDirection = Vector3.zero;
    CharacterController _charControl;
    private Camera cam;
    public LayerMask InteractMap;
    public float interactRange = 10f;

    private void Start()
    {
        cam = Camera.main;
        _charControl = GetComponent<CharacterController>();
    }
    
    // Update is called once per frame
    void Update()
    {
        Movement(); // Checks movement input from player.
        Dash(); // checks every update if player wants to dash.
        Interact(); // Checks if the player interacts with anything

    }
    //Movement of the player
    private void Movement()
    {
        if (_charControl.isGrounded)
        {
            _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            _moveDirection *= movementSpeed;
        }

        //general movement
        _moveDirection.y -= gravity * Time.deltaTime;
        _charControl.Move(_moveDirection * Time.deltaTime);
    }
    //Dash ability
    private void Dash()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _charControl.transform.Translate(_moveDirection*Time.deltaTime * blinkDistance);
        }
    }
    //Checks if player Interacts with its environment
    void Interact()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactRange,InteractMap))
            {
                Debug.Log($"We interacted with a {hit.collider.name} at {hit.point}");
            }
        }
    }
}
