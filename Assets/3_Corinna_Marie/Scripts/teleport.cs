using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
public Transform teleportTarget;
    public Transform teleportStart;
public GameObject thePlayer;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("teleporterTarget"))
        {
            thePlayer.transform.position = teleportTarget.transform.position;
        }
        if (collision.gameObject.CompareTag("teleporterStart"))
        {
            thePlayer.transform.position = teleportStart.transform.position;
        }
    }
}
