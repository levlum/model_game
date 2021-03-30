using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottleSwirl : MonoBehaviour
{
    public float speed; 
    public float spinx, spiny, spinz;
    // Start is called before the first frame update
    void Start()
    {
        speed = Time.deltaTime;
        spinx = Random.Range(800f, 900f);
        spiny = Random.Range(40f, 500f);
        spinz = Random.Range(20f, 200f);
    }

    // Update is called once per frame
    void Update()
    {
    
        
    // transform.Rotate(new Vector3(Random.Range(-100f, 200f),Random.Range(-500.0f, 500.0f),Random.Range(-200.0f, 200.0f)) * speed, Space.World);
       transform.Rotate(new Vector3(spinx, spiny, spinz) * speed, Space.World);
      // Debug.Log("Spinx = " + spinx + "  "+ spiny+  "  " + spinz);
       
    }
     void OnCollisionEnter(Collision collision) {
     speed=0;
     }
}
