using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_ray : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            
            if (hit.rigidbody.tag == "Player")
            {
                if (Input.GetMouseButtonDown(0))

                    hit.transform.Rotate(new Vector3(45, 0, 45));
            }
        }
        
    }
    
}