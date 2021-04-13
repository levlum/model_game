using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
       public float _points; 
    public greenglas scriptgreen;
    public bin scriptbin;
     public plant scriptplant;
    public Text      pointsText;
    // Start is called before the first frame update
    void Start()
    {
        scriptgreen = GameObject.FindObjectOfType<greenglas>();
        scriptbin = GameObject.FindObjectOfType<bin>();
        scriptplant = GameObject.FindObjectOfType<plant>();     
       // totalPoints = scriptbin.points + scriptgreen.points;
        
    }
     void Update()
     {
     
        
     }
        private void FixedUpdate()
        {
           /* Debug.Log("blablabla: " + _points);
            pointsText.text = _points.ToString();*/
        }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
