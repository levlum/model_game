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
    //public AudioClip Backgroundsound;

    public float power = 1f;

    void Start()
    {
        //AudioSource.PlayClipAtPoint(Backgroundsound, transform.position, 0.5f);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(Vector3.up * power, ForceMode.Impulse);

            if (hit.rigidbody.tag == "Platform")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.Rotate(new Vector3(0,0, 15));
                    AudioSource.PlayClipAtPoint(PlatformRotate, transform.position, 0.5f);
                }
            }
            
            if (hit.rigidbody.tag == "Jumpy")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.Rotate(new Vector3(0,0, -15));
                    AudioSource.PlayClipAtPoint(PlatformRotate, transform.position, 1);
                }
            }

        }
    }
}