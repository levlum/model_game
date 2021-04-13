using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachObject : MonoBehaviour {
    

    private void OnTriggerEnter(Collider other) //when colliding
    {
        if (other.gameObject.CompareTag("Player")) //if the other gameObject has the tag "player" (our playersphere)
        {
            other.gameObject.transform.parent = transform; //transform the platform, so that it becomes a parent of the playersphere, as long as they are colliding.
                                                           //So the playersphere is moving along with the platform.
        }
    }

    private void OnTriggerExit(Collider other) //when colliding exit
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.parent = null; //transform the platform back to its original, so the playersphere is no longer a child of the platform.
        }
    }
}
