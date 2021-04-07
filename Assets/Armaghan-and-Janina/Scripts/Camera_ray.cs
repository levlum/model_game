﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Camera_ray : MonoBehaviour

{
    private Rigidbody m_Rigidbody;
    private SerializeField m_speed;


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);

            if (hit.rigidbody.tag == "Platform")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.Rotate(new Vector3(0,0, 20));
                }
            }
            
            if (hit.rigidbody.tag == "Jumpy")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.Rotate(new Vector3(0,0, -20));
                }
            }

        }
    }
}