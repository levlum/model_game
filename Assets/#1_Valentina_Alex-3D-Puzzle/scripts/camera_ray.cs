using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition); //component of type camera
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
        {
            //if (hit.collider.tag == "jumpy")
            //{
                //hit.rigidbody.tag == "jumpy";
                
                var rotObj = hit.collider.GetComponent<rotObj>();
                if (rotObj != null){
                    hit.rigidbody.AddForceAtPosition(Vector3.down * Time.deltaTime * rotObj.torque, hit.point, ForceMode.Impulse);
                }
                else {
                    hit.rigidbody.AddForce(Vector3.up * Time.deltaTime, ForceMode.Impulse);
                }
                //Add things - change them. change the floor.
                //make it in a way, to let users interact with objects 
                //try to not fall down
                //change behaviour of objects
                //find out
                //if the player can do sth
                //hold them up
                //sth you can reach
                //don't change anything in the script
                //just play with it and improve it
                //we need things they are more interesting than others
                //the idea is key
            //}
            
        }
    }
}
