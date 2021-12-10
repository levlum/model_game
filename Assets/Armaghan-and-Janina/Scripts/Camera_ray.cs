using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Camera_ray : MonoBehaviour

{
    private Rigidbody m_Rigidbody;
    private SerializeField m_speed;

    public AudioClip PlatformRotate;

    private float SceneWidth;
    private Vector3 Presspoint;
    private Quaternion StartRotation;
       //public AudioClip Backgroundsound;


    void Start()
    {
        SceneWidth = Screen.width;

        //AudioSource.PlayClipAtPoint(Backgroundsound, transform.position, 0.5f);
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
       

        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);

            if (hit.rigidbody.tag == "Jumpy")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.Rotate(new Vector3(0,0, -15));
                    AudioSource.PlayClipAtPoint(PlatformRotate, transform.position, 1);
                }
            }
           
                //hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);

                if (hit.collider.tag == "Platform")
                {
                    
                    if (Input.GetMouseButtonDown(0))
                    {
                        Presspoint = Input.mousePosition;
                        StartRotation = transform.rotation;
                    }
                    else if (Input.GetMouseButton(0))
                    {
                        float CurrentDistanceBetweenMousePositions = (Input.mousePosition - Presspoint).x;
                        transform.rotation = StartRotation * Quaternion.Euler(Vector3.forward * (CurrentDistanceBetweenMousePositions / SceneWidth) * 360);

                    }

                   else if (Input.mousePosition != default)
                    {
                         hit.transform.Rotate(new Vector3(0, 0, 5));
                        

              
                        AudioSource.PlayClipAtPoint(PlatformRotate, transform.position, 0.5f);
                    }
                }
        }
    }
    
}

    