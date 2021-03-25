using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_ray : MonoBehaviour
{
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject player;

    private Vector3 Cposition;

    // Start is called before the first frame update
    void Start()
    {
        Cposition = new Vector3(0.0f,24.0f,-36.0f);
        Debug.Log("Started");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            
            if (hit.rigidbody.tag == "Player")
            {
                if (Input.GetMouseButtonDown(0))

                    hit.transform.Rotate(new Vector3(45, 0, 45));
            }
        }
        
    }

    void FixedUpdate()
    {
        if(player.transform.position[1]>32)
        {
            Cposition = new Vector3(0.0f,40.0f,-36.0f);
        }
        if(player.transform.position[1]<16)
        {
            Cposition = new Vector3(0.0f,24.0f,-36.0f);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.CompareTag("Level1"))
        {
            
            Level1.SetActive(false);
            Level2.SetActive(true);
            Level3.SetActive(true);
            Cposition = new Vector3(0.0f,24.0f,-36.0f);
            Debug.Log("Level1");
        }
        if (other.gameObject.CompareTag("Level2"))
        {
            Level1.SetActive(true);
            Level2.SetActive(false);
            Level3.SetActive(true);
            Cposition = new Vector3(0.0f,40.0f,-36.0f);
        }
        if (other.gameObject.CompareTag("Level3"))
        {
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(false);
            Cposition = new Vector3(0.0f,56.0f,-36.0f);
        }
    }

    void LateUpdate()
    {
        transform.position = Cposition;
    }
}