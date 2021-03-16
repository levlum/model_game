using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ray_Lev : MonoBehaviour
{
    public GameObject player;
    public float sensitivity;
    public LayerMask ignoreMe;
    public Transform crosshair_t;
    public Transform push_object;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null) {
            hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
        }
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        transform.RotateAround(player.transform.position, -Vector3.up, rotateHorizontal * sensitivity); //use transform.Rotate(-transform.up * rotateHorizontal * sensitivity) instead if you dont want the camera to rotate around the player
        transform.RotateAround(Vector3.zero, transform.right, rotateVertical * sensitivity); // again, use transform.Rotate(transform.right * rotateVertical * sensitivity) if you don't want the camera to rotate around the player
        
        if (!Input.GetButton("Fire1"))
        {
            push_object.GetComponent<Rigidbody>().isKinematic = true; //make push object not physical
            push_object.position = new Vector3(push_object.position.x, -1f, push_object.position.z);
        }
        if (Physics.Raycast(ray, out hit, 50f, ~ignoreMe))
        {
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            }
            else if (hit.collider.name == "Floor")
            {
                crosshair_t.position = new Vector3(hit.point.x, 0.51f, hit.point.z); //above floor
                if (Input.GetButton("Fire1"))
                {
                    if (push_object.GetComponent<Rigidbody>().isKinematic)
                    {
                        push_object.position = new Vector3(hit.point.x, Mathf.Max(-1f, push_object.position.y), hit.point.z);
                        push_object.GetComponent<Rigidbody>().isKinematic = false;

                    }
                    push_object.GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * Time.deltaTime, ForceMode.Impulse);
                }
            }
        }
    }
}
