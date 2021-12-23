using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public float moveSpeed;
    public Transform target;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -18)
        {
            transform.position = target.position + Vector3.right * 17.8f;
        }

    }
}
