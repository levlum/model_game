using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace yasi_caro {
    public class camera_ray : MonoBehaviour
    {
        public LayerMask ignoreMe;
        public Transform crosshair_t;
        public float power = 10f;
        // public Transform push_object;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            RaycastHit hit;
            var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit, 500f, ~ignoreMe)) {
                if (hit.rigidbody != null) {
                    var direction = hit.point - hit.transform.position;
                    hit.rigidbody.AddForce(direction * Time.deltaTime * power);
                }
                
                Debug.Log("mouse ray collission.");
            } 
        }
    }
}
