using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour
{
    private float rotSpeed = 5;

    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
        
        transform.RotateAround(Vector3.up, -rotY);
        transform.RotateAround(Vector3.left, rotX);
    }
}
