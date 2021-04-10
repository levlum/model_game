using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plant : MonoBehaviour
{

    public int plantCount = 0;
    public static float point; 
    public float _point;
    public points script;
    public Slider slider;
public AudioSource plantAudio;
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
            //greenText.text = greenCount.ToString();
        }
        /*private void OnTriggerEnter(Collider other)

        {
                script = GameObject.FindObjectOfType<points>(); 
         
            if (other.gameObject.CompareTag("house"))
            {
                //this.gameObject.SetActive(false);
                 script._points++;
               UnityEngine.Debug.Log("Plant: " +script._points);
               
                 
            }
             if (other.gameObject.CompareTag("can") ||other.gameObject.CompareTag("bottle"))
            {
            
                  script._points--;
               UnityEngine.Debug.Log("Points " + script._points);
            }
        }*/

         public Transform explosionPrefab;
                void OnCollisionEnter(Collision collision) {
                   if (collision.gameObject.tag == "house")
                   {
                      script._points+=3;
                      slider.value = script._points;
                         ContactPoint contact = collision.contacts[0];
                         Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
                        Vector3 pos = contact.point;
                         Instantiate(explosionPrefab, pos, rot);
                        Debug.Log("Plant");
                        plantAudio.Play();
                        
                       gameObject.SetActive(false);
                   }
                }
}
