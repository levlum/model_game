using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camray : MonoBehaviour
{
    public int maxDistance;
    public int layerMask;
    public int maxHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // fixedUpdate  can run once, zero, or several times per frame, 
    //depending on how many physics frames per second are set in the time settings,
    //and how fast/slow the framerate is.
    void Update()
    {
        RaycastHit hit;
        //ray = Vectororigin, out hit = vector direction
        
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, maxDistance) && hit.rigidbody != null)
        {
           
            //forcemode applies instantforce depending on mass
            //.AddForce(ray.direction * hitForce)
               if(hit.collider.GetComponent<Transform>().position.y < maxHeight)
            {

                hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
                Debug.Log("I hit: " + hit.collider);

            }
           
        }
        
    }
}
