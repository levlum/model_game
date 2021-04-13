using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bergerkardel {
    public class camera_ray : MonoBehaviour
    {
            public Transform player;
            public Vector3 offset = new Vector3(0f, 10f, -70f);
            public float smoothTime = 0.9F;
            private Vector3 velocity = Vector3.zero;

            // Start is called before the first frame update
            void Start()
        {    }

        // Update is called once per frame
        void Update()
        {
            RaycastHit hit;
            var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 5000))
            {
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(Vector3.up * Time.deltaTime, ForceMode.Impulse);
                }
            }

                // Define a target position above and behind the target transform
                Vector3 targetPosition = player.position + offset;

                // Smoothly move the camera towards that target position
                transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}