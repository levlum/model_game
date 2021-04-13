using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace markus_max_karo {
    public class CameraController : MonoBehaviour
    {
        public Transform player;
        public Vector3 offset = new Vector3(0f, 10f, -70f);
        public float smoothTime = 0.3F;
        private Vector3 velocity = Vector3.zero;

        void FixedUpdate()
        {
            // Define a target position above and behind the target transform
            Vector3 targetPosition = player.position + offset;

            // Smoothly move the camera towards that target position
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}