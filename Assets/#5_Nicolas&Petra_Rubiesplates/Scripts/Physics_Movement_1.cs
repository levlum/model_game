using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics_Movement_1 : MonoBehaviour
{
    public float force = 100f;
    public Transform startPosition;
    public Transform endPosition;

    private float foward = 1f;
    private Vector3 direction;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = endPosition.position - startPosition.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((foward>0 && transform.position.z < endPosition.position.z) || (foward < 0 && transform.position.z > startPosition.position.z)){
            rb.AddForce(direction * foward * force);
        }
        else {
            rb.velocity = Vector3.zero;
            foward *= -1;
        }
    }
}
