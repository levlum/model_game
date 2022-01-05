using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour
{
 //  [SerializeField] private Material b_idleMaterial = null;
   // [SerializeField] private Material b_touchMaterial = null;

    public float power;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 500))
        {
            //hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse
            var bubbles = GameObject.FindGameObjectsWithTag("bubble");
            var dogs = GameObject.FindGameObjectsWithTag("dog");
            var dogPosition = Vector3.zero;
            foreach (var dog in dogs)
            {
                dogPosition = dog.transform.position;
                var direction = hit.point - dogPosition;
                var distance = direction.magnitude;
                direction.Normalize();
                // bubble.GetComponent<Rigidbody>().AddForce(direction * Time.deltaTime * power, ForceMode.Impulse);
                dog.GetComponent<Rigidbody>().AddForce(direction * Time.deltaTime * power * 1f);
                // bubble.GetComponent<Renderer>().material = b_touchMaterial;
            }

            foreach (var bubble in bubbles)
            {
                var direction = bubble.transform.position - dogPosition;
                var distance = direction.magnitude;
                direction.Normalize();
                // bubble.GetComponent<Rigidbody>().AddForce(direction * Time.deltaTime * power, ForceMode.Impulse);
                bubble.GetComponent<Rigidbody>().AddForce(direction * Time.deltaTime * power * 1f / distance);
               // bubble.GetComponent<Renderer>().material = b_touchMaterial;
            }
            Debug.Log("HI");

        }
        else {
            var bubbles = GameObject.FindGameObjectsWithTag("bubble");
            foreach (var bubble in bubbles)
            {
                
             //   bubble.GetComponent<Renderer>().material = b_idleMaterial;
            }

        }

     
        
    }
}