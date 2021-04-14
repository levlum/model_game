using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveie : MonoBehaviour
{
    
    private Rigidbody rb;
    private float moveSpeed;
    private float dirX, dirZ;

    private void Start()
    {
        moveSpeed = 3f;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        dirX = Input.GetAxis("Vertical") * moveSpeed;
        dirZ = Input.GetAxis("Horizontal") * moveSpeed;
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirZ, rb.velocity.y, dirX);
    }
}

    

