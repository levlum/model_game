using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputManager;

public class funnel_controller : MonoBehaviour
{
    private GameObject[] funnel;
    private Vector3 currFunnelPos;
    bool stopRightMovement, stopLeftMovement, stopBackMovement, stopFrontMovement = false;
    [SerializeField] private float funnelSpeed = 1.0f;
    [SerializeField] private float strength = 1.0f;
    void Start()
    {
        funnel = GameObject.FindGameObjectsWithTag("funnel");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(stopBackMovement);
        if (Input.GetKey(KeyCode.RightArrow) && !stopRightMovement)
        {
            funnel[0].GetComponent<Rigidbody>().AddForce(new Vector3(funnelSpeed, 0,0) * Time.deltaTime * strength, ForceMode.Impulse);
            //funnel[0].transform.position += new Vector3(funnelSpeed, 0,0);
            stopRightMovement = true;
        } 
        if (Input.GetKey(KeyCode.LeftArrow) && !stopLeftMovement)
        {
            funnel[0].GetComponent<Rigidbody>().AddForce(new Vector3(-funnelSpeed, 0,0) * Time.deltaTime * strength, ForceMode.Impulse);
            //funnel[0].transform.position += new Vector3(-funnelSpeed, 0,0);
            stopLeftMovement = true;
           
        } 
        if (Input.GetKey(KeyCode.UpArrow) && !stopBackMovement )
        {
            funnel[0].GetComponent<Rigidbody>().AddForce(new Vector3(0, 0,funnelSpeed) * Time.deltaTime * strength, ForceMode.Impulse);
            //funnel[0].transform.position += new Vector3(0, 0,1f);
            stopBackMovement = true;
        } 
        if (Input.GetKey(KeyCode.DownArrow) )
        {
            funnel[0].GetComponent<Rigidbody>().AddForce(new Vector3(0, 0,-funnelSpeed) * Time.deltaTime * strength, ForceMode.Impulse);
            //funnel[0].transform.position += new Vector3(0, 0,-1f);
            stopFrontMovement = true;
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
        
        if (funnel[0].transform.position.x <= -18f)
        {
            currFunnelPos.x = 18f;
            stopLeftMovement = true;
        }
        else
        {
            stopLeftMovement = false;
        }
        
        if (funnel[0].transform.position.z >= 40f)
        {
            currFunnelPos.z = 40f;
            stopBackMovement = true;
        }
        else
        {
            stopBackMovement = false;
        }
        
        if (funnel[0].transform.position.z <= -25f)
        {
            currFunnelPos.z = -25f;
            stopFrontMovement = true;
        }
        else
        {
            stopFrontMovement = false;
        }
    }
    
}
