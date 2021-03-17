using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ray : MonoBehaviour
{
    public Transform targetObject;
    private Vector3 initalOffset;
    private Vector3 cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        initalOffset = transform.position - targetObject.position;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50))
        {
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            }
        }

        cameraPosition = targetObject.position + initalOffset;
        transform.position = cameraPosition;
    }
}
