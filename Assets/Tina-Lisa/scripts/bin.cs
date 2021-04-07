using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bin : MonoBehaviour
{
    public Text binText;
    public int binCount = 0;
     private static float  points; 
    public points script;
    public float _point;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.FindObjectOfType<points>();
     _point = script._points;
    
    }

    // Update is called once per frame
    void Update()
    {
        points = script._points;  //  Update our score continuously.
       binText.text = script._points.ToString();
    }
   private void FixedUpdate()
        {
            //binText.text = binCount.ToString();
        }
        private void OnTriggerEnter(Collider other)

        {
            script = GameObject.FindObjectOfType<points>();
            if (other.gameObject.CompareTag("can"))
            {
                other.gameObject.SetActive(false);
              script._points+=1;
              slider.value = script._points;
               UnityEngine.Debug.Log("Points: " + script._points);
            }
            if (other.gameObject.CompareTag("bottle"))
            {
                script._points--;
                slider.value = script._points;
               UnityEngine.Debug.Log("Points: " + script._points);
            }
        }
}
