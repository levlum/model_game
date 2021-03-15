using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_8 : MonoBehaviour
{
     public int _layermask;
    public Vector3 _direction;
    public ForceMode _forcemode;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, _layermask) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(_direction, _forcemode);
        }
    }
}
