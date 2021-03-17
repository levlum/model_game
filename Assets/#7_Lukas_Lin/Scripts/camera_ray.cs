using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ray : MonoBehaviour
{
    //perfect porn music: https://www.youtube.com/watch?v=pCu-lqJ3nuk&ab_channel=TheChilloutChannel
    [SerializeField] private float cameraSpeed = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Camera>().transform.position += new Vector3(0,-1f,0);

        if (GetComponent<Camera>().transform.position.y >= 60.0f)
        {
            GetComponent<Camera>().transform.position += new Vector3(0,-cameraSpeed,0);
            
        }
        else
        {
            GetComponent<Camera>().transform.position = GetComponent<Camera>().transform.position;
        }
        /*RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null){ 
            
                hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            
           
        }
        */
    }
}
