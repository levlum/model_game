using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableGravity : MonoBehaviour
{
    public GameObject turtle;
    

    public GameObject waterSurface;

    private float waterSurfHeight;

    private float turtleHeight;
    // Start is called before the first frame update
    void Start()
    {
        waterSurfHeight = waterSurface.transform.position.y;
        //GetComponent<Rigidbody>().detectCollisions = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        turtleHeight = turtle.transform.position.y;
        if (turtleHeight > (waterSurfHeight + 5))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
