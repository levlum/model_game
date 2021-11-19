using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class timer : MonoBehaviour
{
    private float currentTime;
    public int startMinutes;
    public Text currentTimeText;
    public GameObject gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes * 60; // having it in seconds
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime - Time.deltaTime;
        if (currentTime <= 0)
        {
            currentTime = 0;
            gameOver.SetActive(true);
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime); //convert seconds into minutes
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
        
    }
}
