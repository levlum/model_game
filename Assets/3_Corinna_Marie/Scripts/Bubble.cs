using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour { 
    public Vector3 jump;
    public Vector3 side;
    public Vector3 sideleft;
    public float jumpForce = 4.0f;
   // public float speed = 10.0f;
    private Rigidbody rb;

    // private Vector2 screenBounds;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
     //   rb.velocity = new Vector3(0, speed, 0);
      //  screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
      jump = new Vector3(0.0f, 2.0f, 0.0f);
      side = new Vector3(0.0f, 0.0f, 2.0f);
      sideleft = new Vector3(0.0f, 0.0f, -2.0f);

    }

    void Update()
    {
        // var height = GetComponent<Transform>().position.y;
       // rb.AddForce(new Vector3(0, speed, 0) * Time.deltaTime * 1 / height);
        //if(transform.position.y < screenBounds.y)
        //{
        //    Destroy(this.gameObject);
        //}
        //transform.Rotate(new Vector3(0f, 100f, 0f) * Time.deltaTime);

    }

   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("jumpplane"))
        {
                rb.AddForce(jump*jumpForce,ForceMode.Impulse);

                //GetComponent<Rigidbody>().AddForce(Vector3.up * Time.deltaTime * 10f, ForceMode.Impulse);
        }

        if (other.gameObject.CompareTag("sideplane"))
        {
            rb.AddForce(side * jumpForce, ForceMode.Impulse);

            //GetComponent<Rigidbody>().AddForce(Vector3.up * Time.deltaTime * 10f, ForceMode.Impulse);
        }

        if (other.gameObject.CompareTag("sideplaneleft"))
        {
            rb.AddForce(side * jumpForce, ForceMode.Impulse);

            //GetComponent<Rigidbody>().AddForce(Vector3.up * Time.deltaTime * 10f, ForceMode.Impulse);
        }
    }

    

}
