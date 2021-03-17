using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace caro_julian {
public class Camera_ray : MonoBehaviour
{

        public float push_strength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(Vector3.up * push_strength * Time.deltaTime, ForceMode.Impulse);
          
        }

        //gameObject.GetComponent<Rigidbody2D>().AddForce((Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized * moveForce, ForceMode2D.Impulse);
    }
}
}