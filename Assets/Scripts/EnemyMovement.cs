using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement  : MonoBehaviour
{
    public Transform target;
    public float speed = 20f;
    private Rigidbody _rig;
    
    
    // Start is called before the first frame update
    void Start()
    { 
        _rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        _rig.MovePosition(pos);
        transform.LookAt(target);
        if (target==null)
        {
            Destroy(this.GameObject());
        }
    }
}
