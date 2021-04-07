using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Transform teleportDestination_Level2;
    public Transform teleportDestination_Level1;

    //Teleport the Player into another Level by Colliding with a specific Object
    private void OnTriggerEnter(Collider other) //if the Playersphere collides with another object
    {
        if (other.gameObject.CompareTag("Teleport")) //and the other object has the tag "Teleport"
        {
            gameObject.transform.position = teleportDestination_Level2.position; //set the position of the Player to the position of the Destination-Object (Level2)
        }

        if (other.gameObject.CompareTag("Teleport_Outside")) //if it collides with another object that has the tag "Teleport_Outside"
        {
            gameObject.transform.position = teleportDestination_Level1.position; //set the position of the Player to the position of the Destination-Object (Level1)
        }
    }

}



