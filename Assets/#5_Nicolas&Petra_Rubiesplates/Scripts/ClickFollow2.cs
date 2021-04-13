using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ClickFollow2 : MonoBehaviour
{
    public float speed;
    public CharacterController controller;
    private Vector3 position;
    public int arrive = 1;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Locate where we click
            locatePosition();
        }
        MoveToPos();
        //Move to where we click
    }
    void locatePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            Debug.Log(position);
        }

    }
    void MoveToPos()
    {
        if (Vector3.Distance(transform.position, position) > 1)
        {
            Quaternion newRotation = Quaternion.LookRotation(position - transform.position);
            newRotation.x = 0f;
            newRotation.z = 0f;

            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 10);
            controller.SimpleMove(transform.forward * speed);


        }


    }
}