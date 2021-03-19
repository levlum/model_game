using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ray_lulin : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private GameObject firstObject;
    private Vector3 m_offset;
    void Start()
    {
        m_offset = gameObject.transform.position - firstObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null){ 
            
                hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            
           
        }
        
        //float CameraY = GetComponent<Camera>().transform.position.y;

        if (GetComponent<Camera>().transform.position.y >= 40f)
        {
            gameObject.transform.position = firstObject.transform.position + m_offset; 
            //GetComponent<Camera>().transform.position -= new Vector3(0, speed,0);
            //CameraY = firstObject.transform.position.y;
            //GetComponent<Camera>().transform.position.y = 40f;
            //firstObject.transform.position.y
            //gameObject.transform.position.y = firstObject.transform.position.y;
        }
        
    }
}
