using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour
{
    [SerializeField]
    float torque = 500f;
    private Rigidbody rb;
    private float rotSpeed = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
   /* private void OnMouseDrag()
    {
       // float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotX = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
        
        //transform.RotateAround(Vector3.up, rotZ);
        transform.RotateAround(Vector3.left, rotX);
    }*/
   
   private void OnMouseDrag()
   {
       float rotX = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
       transform.RotateAround(Vector3.left, rotX);
       rb.AddRelativeTorque(transform.up * torque * rotX);
   }
}
