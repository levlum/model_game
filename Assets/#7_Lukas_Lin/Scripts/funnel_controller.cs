using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputManager;

public class funnel_controller : MonoBehaviour
{
    private GameObject[] funnel;
    private Vector3 currFunnelPos;
    bool stopRightMovement = false;
    void Start()
    {
        funnel = GameObject.FindGameObjectsWithTag("funnel");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && !stopRightMovement)
        {
            funnel[0].transform.position += new Vector3(1f, 0,0);
        } 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            funnel[0].transform.position += new Vector3(-1f, 0,0);
        } 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            funnel[0].transform.position += new Vector3(0, 0,1f);
        } 
        if (Input.GetKey(KeyCode.DownArrow))
        {
            funnel[0].transform.position += new Vector3(0, 0,-1f);
        }

        currFunnelPos = funnel[0].transform.position;
        
        if (funnel[0].transform.position.x >= 18f)
        {
            currFunnelPos.x = 18f;
            stopRightMovement = true;

        }
        else
        {
            stopRightMovement = false;
        }
    }
    
}
