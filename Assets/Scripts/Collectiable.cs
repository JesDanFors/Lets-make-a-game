using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Collectiable : MonoBehaviour
{
    public int collected;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collected++;
            Debug.Log(collected);
            Destroy(gameObject);
        }
    }
}
