using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbles : MonoBehaviour
{
    private float time;

    private float x, y, z;
    private Vector3 pos;
    
    Rigidbody rigidBody;
    private float force = 20f;

    void Start()
    {
        // randomize start position
        x  = Random.Range(5, 95);
        y = 2;
        z = Random.Range(5, 95);
        pos = new Vector3(x, y, z);
        transform.position = pos;
        
        //Fetch the Rigidbody from the GameObject with this script attached
        rigidBody = GetComponent<Rigidbody>();
        force = Random.Range(200, 600);
        rigidBody.AddForce(0, force, 0, ForceMode.Acceleration);
    }

    public void respawnBubble()
    {
        gameObject.SetActive(false);
        // change random spawn position
        x  = Random.Range(5, 95);
        y = 2;
        z = Random.Range(5, 95);
        pos = new Vector3(x, y, z);
        transform.position = pos;
        // re-activate object
        gameObject.SetActive(true);
    } 
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WaterSurface"))
        {
            respawnBubble();
        }
    }
}
