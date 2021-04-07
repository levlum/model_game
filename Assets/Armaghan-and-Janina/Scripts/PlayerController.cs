using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform teleportDestination_inside;
    public Transform teleportDestination_outside;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Teleport"))
        {
            gameObject.transform.position = teleportDestination_inside.position;
        }

        if (other.gameObject.CompareTag("Teleport_Outside"))
        {
            gameObject.transform.position = teleportDestination_outside.position;
        }
    }

}



