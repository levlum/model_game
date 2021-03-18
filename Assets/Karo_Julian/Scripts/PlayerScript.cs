using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace karo_julian
{
    public class PlayerScript : MonoBehaviour
    {
        public bool canjump = false;

        public void Start()
        {
           
        }

        private void Update()
        {
            
            
        }



        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Platform"))
            {
                UnityEngine.Debug.Log("touchy");
                canjump = true;
                
            }
            else
            {
                canjump = false;
            }
            
        }

        public void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.CompareTag("Platform"))
            {
                UnityEngine.Debug.Log("no touchy");
                canjump = false;

            }
        }
    }
}
