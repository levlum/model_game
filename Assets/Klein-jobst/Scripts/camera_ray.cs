using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace klein_jobst {
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

            var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 150) && hit.rigidbody !=null)
            {
                hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            }
        }
    }
}
