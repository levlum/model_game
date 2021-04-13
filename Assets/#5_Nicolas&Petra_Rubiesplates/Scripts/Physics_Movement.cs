using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics_Movement : MonoBehaviour
{
    public float force = 100f;
    public Transform startPosition;
    public Transform endPosition;

    private float up = 1f;
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
        if ((up>0 && transform.position.y < endPosition.position.y) || (up<0 && transform.position.y > startPosition.position.y)){
            rb.AddForce(direction * up * force);
        }
        else {
            rb.velocity = Vector3.zero;
            up *= -1;
        }
    }
}
