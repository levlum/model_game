using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputManager;

public class funnel_controller : MonoBehaviour
{
    private GameObject[] funnel;
    private Vector3 currFunnelPos;
    [SerializeField] private float funnelSpeed = 1.0f;
    [SerializeField] private float strength = 1.0f;
    void Start()
    {
        funnel = GameObject.FindGameObjectsWithTag("funnel");
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            funnel[0].GetComponent<Rigidbody>().AddForce(new Vector3(funnelSpeed, 0,0) * Time.deltaTime * strength, ForceMode.Impulse);
            //funnel[0].transform.position += new Vector3(funnelSpeed, 0,0);
        } 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            funnel[0].GetComponent<Rigidbody>().AddForce(new Vector3(-funnelSpeed, 0,0) * Time.deltaTime * strength, ForceMode.Impulse);
        } 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            funnel[0].GetComponent<Rigidbody>().AddForce(new Vector3(0, 0,funnelSpeed) * Time.deltaTime * strength, ForceMode.Impulse);
        } 
        if (Input.GetKey(KeyCode.DownArrow) )
        {
            funnel[0].GetComponent<Rigidbody>().AddForce(new Vector3(0, 0,-funnelSpeed) * Time.deltaTime * strength, ForceMode.Impulse);
        }
    }
    
}
