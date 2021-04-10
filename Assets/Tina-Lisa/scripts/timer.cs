using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    public bool finished = false;
    public float countdown = 60;
    
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(finished) 
        return; 
    
       
    

        float t = Time.time - startTime;

      
        string seconds = (t % 60).ToString("f0");

        timerText.text =  seconds;
    }

    public void Finish()
    {
        timerText.color = Color.yellow;
    }
}
