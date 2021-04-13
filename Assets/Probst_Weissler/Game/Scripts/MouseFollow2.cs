using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow2 : MonoBehaviour
{
    Camera cam;
    Collider planeCollider;
    public Collider waterSurfCollider;
    public float speed = 5;
 
    RaycastHit hit;
    Ray ray;
    
    Vector3 startPos;

    void Start()
    {
        cam = GameObject.Find("MainCamera").GetComponent<Camera>();
        planeCollider = GameObject.Find("Plane").GetComponent<Collider>();
        startPos = transform.position;
    }
    
    void Update()
    {
       //transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5)); //funktioniert
       if (Input.GetMouseButton(0))
       {
           ray = cam.ScreenPointToRay(Input.mousePosition);
           if (Physics.Raycast(ray, out hit))
           {
               if (hit.collider == planeCollider)  /// ich glaube hier müsste man den plane collider extra machen
                   transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * speed);
               else if (hit.collider.tag == "bubbleCollider")
               {
                   bubbles bubble = hit.transform.gameObject.GetComponent(typeof(bubbles)) as bubbles;
                   bubble.respawnBubble();
                   gameObject.GetComponent<Rigidbody>().AddForce(0, 15, 0, ForceMode.Impulse);
               }

               transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z)); 
               transform.Rotate(-90, 0, 90);

           }
       }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bombCollider"))
        {
            transform.position = startPos;
        }
    }
}


