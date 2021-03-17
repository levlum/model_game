using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class funnel_controller : MonoBehaviour
{
    
    private GameObject[] funnels;
   
    
    [SerializeField] private float m_speed = 1f;

    
    void Start()
    {
        funnels = GameObject.FindGameObjectsWithTag("funnel");
     
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            funnels[0].transform.position += new Vector3(1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            funnels[0].transform.position += new Vector3(-1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            funnels[0].transform.position += new Vector3(0f, 0, 1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            funnels[0].transform.position += new Vector3(0f, 0, -1f);
        }
    }
    
}
