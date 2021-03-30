using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class points : MonoBehaviour
{
 
    public float _points; 
    public greenglas scriptgreen;
    public bin scriptbin;
    public Text      pointsText;
  

    void Start()
    {
        scriptgreen = GameObject.FindObjectOfType<greenglas>();
        scriptbin = GameObject.FindObjectOfType<bin>();

       // totalPoints = scriptbin.points + scriptgreen.points;
        
    }
     void Update()
     {
         //pointsText.text = _points.ToString(); 
        //_lifes = script.lifes;  //  Update our score continuously.
        
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
