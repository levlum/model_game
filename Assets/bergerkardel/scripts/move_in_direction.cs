using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bergerkardel
{
    public class move_in_direction : MonoBehaviour
    {
        public int speed;
        Vector3 startPosition, driftPosition;

        public float driftSeconds = 10;
        private float driftTimer = 0;
        private bool isDrifting = false;

        void Start()
        {
            startPosition = transform.position;
        }

        void OnMouseOver()
        {
            isDrifting = false;
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        void OnMouseExit()
        {
            isDrifting = true;
            driftTimer = 0;
            driftPosition = transform.position;
        }

        void StopDrifting()
        {
            isDrifting = false;
            transform.position = startPosition;
        }

        void Update()
        {
            if (isDrifting)
            {
                driftTimer += Time.deltaTime;
                if (driftTimer > driftSeconds)
                {
                    StopDrifting();
                }
                else
                {
                    float ratio = driftTimer / driftSeconds;
                    transform.position = Vector3.Lerp(driftPosition, startPosition, ratio);
                }
            }
        }
    }
}