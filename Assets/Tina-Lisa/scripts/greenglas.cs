using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class greenglas : MonoBehaviour
{
    public Text greenText;
    public int greenCount = 0;
          public static float point; 
      public float _point;
    public points script;
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
           
        _point = script._points;  //  Update our score continuously.
      greenText.text = script._points.ToString(); 
       //Debug.Log("Punkte: " + point);
    }
    private void FixedUpdate()
        {
            //greenText.text = greenCount.ToString();
        }
        private void OnTriggerEnter(Collider other)

        {script = GameObject.FindObjectOfType<points>(); 
            if (other.gameObject.CompareTag("bottle"))
            {
                other.gameObject.SetActive(false);
                 script._points++;
               UnityEngine.Debug.Log("Points: " +script._points);
                 
            }
            if (other.gameObject.CompareTag("can"))
            {
            
                  script._points--;
               UnityEngine.Debug.Log("Points " + script._points);
            }
        }
}
