using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachObjectArma : MonoBehaviour {
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.gameObject == Player)
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.parent = null;
        }
    }
}
