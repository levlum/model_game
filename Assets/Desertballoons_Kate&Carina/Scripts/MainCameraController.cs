using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public LayerMask ignoreMe;
    public float pushing_strength = 1f;

    private GameObject[] jumpy_objects;

    // Start is called before the first frame update
    void Start()
    {
        jumpy_objects = GameObject.FindGameObjectsWithTag("jumpy");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 500f, ~ignoreMe) && hit.collider.name == "Mixed_Ground_01")
        {
                                                                                 //use all objects with tag "jumpy"
            foreach (var one_jumpy in jumpy_objects)
            {
                Vector3 power_direction = hit.point - one_jumpy.GetComponent<Transform>().position;
                one_jumpy.GetComponent<Rigidbody>().AddForce(power_direction, ForceMode.Force);
            }
        }
    }
}