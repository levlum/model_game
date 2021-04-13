using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace karo_julian
{
    public class PlayerScript : MonoBehaviour
    {
        //public bool canjump = false;

        private CharacterController myController;
        public float gravityForce;
        public float ySpeed;
        public float jumpForce;
        public float hangTime;
        public float hangTimer;
        public float gravityModifier;
        public float ForwardSpeed;
        public float runSpeed;
        public float lerpTime;

        void Start()
        {
            myController = GetComponent<CharacterController>();
        }

        void FixedUpdate()
        {

            MyGravity();
            Jump();
            ForwardMovement();
            SpeedApply();

        }



       /* public void OnCollisionEnter(Collision collision)
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
        } */

        void Jump()
        {
            if(Input.GetButton("Fire1"))
            {
                if(myController.isGrounded)
                {
                    hangTimer = hangTime;
                    ySpeed = jumpForce;

                }
                else
                {
                    if(hangTimer > 0)
                    {
                        hangTimer -= Time.deltaTime;
                        ySpeed += gravityModifier * hangTimer * Time.deltaTime;
                    }
                }
            }
        }

        void MyGravity()
        {
            ySpeed = myController.velocity.y;
            ySpeed -= gravityForce * Time.deltaTime;
        }

        void ForwardMovement()
        {
            if(myController.isGrounded)
            {
                if (ForwardSpeed <= runSpeed - .1f || ForwardSpeed >= runSpeed + .1f)
                    ForwardSpeed = Mathf.Lerp(ForwardSpeed, runSpeed, lerpTime);
                else
                    ForwardSpeed = runSpeed;
            }
        }

        void SpeedApply()
        {
            myController.Move(transform.forward * ForwardSpeed * Time.deltaTime);
            myController.Move(new Vector3(0, ySpeed, 0) * Time.deltaTime);
        }

        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            if (hit.gameObject.tag == "Finish")
            {
                SceneManager.LoadScene(0);
                // UnityEditor.EditorApplication.ExitPlaymode();
            }
        }

    }




}
