using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaCtrl : MonoBehaviour
{
    
    Vector3 targetPosition;
    Vector3 lookAtTarget;
    Quaternion playerRot;
    public float rotSpeed = 3.0f;
    public float speed = 5.0f;
    bool moving = false;

    private Vector3 velocity;
    public float jumpHeight = 10f;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetTargetPosition();
        }
        if (moving)
        {
            Move();
        }
        /*if (Input.GetMouseButtonDown(1))
        {
            jumpCube();
        }*/
    }
    void SetTargetPosition()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo, Mathf.Infinity))
        {
            //this.transform.LookAt(hitInfo.point);
            targetPosition = hitInfo.point;
            lookAtTarget = new Vector3(targetPosition.x - transform.position.x, transform.position.y, transform.position.z - transform.position.z);
            playerRot = Quaternion.LookRotation(lookAtTarget);
            moving = true;
        }

    }
    void Move()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, playerRot, rotSpeed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if(transform.position == targetPosition)
        {
            moving = false;
        }
    }
  /*  private void jumpCube()
    {
       rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
    }*/
}
