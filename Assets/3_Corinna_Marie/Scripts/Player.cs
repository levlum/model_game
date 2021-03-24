using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    [SerializeField] private float m_speed = 1f;
    private Rigidbody m_playerRigidbody;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       m_playerRigidbody = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    
    private void OnCollisionStay()
    {
        isGrounded= true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0f,0f,0f);
        m_playerRigidbody.AddForce((movement*m_speed));
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            m_playerRigidbody.AddForce(jump*jumpForce,ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
