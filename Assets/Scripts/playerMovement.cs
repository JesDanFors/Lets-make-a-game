using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public int movementSpeed = 25;
    public int maxSpeed = 30;
    public int dashRange = 10;

    // FixedUpdate is called 50 times per second
    private void FixedUpdate()
    { 
        Rigidbody rigid = GetComponent<Rigidbody>();
            if (Input.GetKey(KeyCode.A))
            {
                rigid.AddForce(Vector3.left * movementSpeed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                rigid.AddForce(Vector3.back * movementSpeed);
            }

            if (Input.GetKey(KeyCode.W))
            {
                rigid.AddForce(Vector3.forward * movementSpeed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                rigid.AddForce(Vector3.right * movementSpeed);
            }

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * dashRange);
            }
    }
}
