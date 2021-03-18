using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;     //variable
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition); // we create a ray
        if (Physics.Raycast(ray, out hit, 50) && (hit.rigidbody != null))
        {       //put it into information with physics and give information
            if (hit.collider.tag == "jumpy")
            {
                hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            }
        }
    }
}