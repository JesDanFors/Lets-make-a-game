using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectiable : MonoBehaviour
{
    public int _collected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        _collected++;
        Debug.Log(_collected);
        Destroy(gameObject);
    }
}
