using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ray_lulin : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private GameObject firstObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null){ 
            
                hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            
           
        }

        if (GetComponent<Camera>().transform.position.y >= 30f)
        {
            GetComponent<Camera>().transform.position -= new Vector3(0, speed,0);
        }
        
    }
}
