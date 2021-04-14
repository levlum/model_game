using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public GameObject turtle;

    private Vector3 startPos;

    private Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = turtle.transform.position.x;
        float y = startPos.y + turtle.transform.position.y;
        float z = turtle.transform.position.z;
        Vector3 targetPos = new Vector3(x, y, z);
        transform.position = targetPos;
    }
}
