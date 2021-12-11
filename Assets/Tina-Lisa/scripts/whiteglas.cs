using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class whiteglas : MonoBehaviour
{
    public static float point; 
    public float _point;
    public points script;
    public Slider slider;
    public AudioSource glas;
    public AudioSource error;
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
     
       //Debug.Log("Punkte: " + point);
    }
    private void FixedUpdate()
        {
           
        }
        private void OnTriggerEnter(Collider other)

        {script = GameObject.FindObjectOfType<points>(); 
            if (other.gameObject.CompareTag("white"))
            {
                other.gameObject.SetActive(false);
                 script._points++;
                 slider.value = script._points;
               UnityEngine.Debug.Log("Points: " +script._points);
               glas.Play();
                 
            }
            else if (other.gameObject.CompareTag("can") || other.gameObject.CompareTag("green")  || other.gameObject.CompareTag("brown")|| other.gameObject.CompareTag("samen"))
            {
            
                  script._points--;
                  slider.value = script._points;
               UnityEngine.Debug.Log("Points " + script._points);
               error.Play();
            }
        }
}
