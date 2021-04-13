using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    float rotSpeed = 20;
    private Vector3 MousePosition;
    private Vector3 diff;
    private float rotY;

    public Vector3 currentRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        currentRot = GetComponent<Transform>().eulerAngles;

        if ((Input.GetAxis("Horizontal") < .2) )
        {
            transform.Rotate(0, 1, 0);
        }

        if ((Input.GetAxis("Horizontal") > -.2) )
        {
            transform.Rotate(0, -1, 0);
        }

    }
}
