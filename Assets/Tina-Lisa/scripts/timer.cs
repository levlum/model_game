using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    public bool finished = false;
    public float timeLeft = 60f;
     public GameObject endscreen;
     public Text timeend;
     public float timeEnde;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timeEnde = 60f - timeLeft;
        if(finished) {
 endscreen.gameObject.SetActive(true);
 timeend.text = timeEnde.ToString("f0");
           return;  
        }
        
    
         timeLeft -= Time.deltaTime;
         timerText.text = timeLeft.ToString("f0");
         if(timeLeft < 0)
         {
             Debug.Log("gameOver");
              finished = true;
               
           ;
         }
    

       // float t = Time.time - startTime;

       // string minutes = ((int) t / 60).ToString();
       // string seconds = (t % 60).ToString("f0");

       // timerText.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        timerText.color = Color.yellow;
    }
}
