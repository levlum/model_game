using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.PlayerLoop;

public class timer : MonoBehaviour
{
    private float currentTime;
    public int startMinutes;
    public Text currentTimeText;
    public GameObject gameOver;
    public GameObject fireImage1;
    public GameObject fireImage2;
    public GameObject fireImage3;
    public GameObject fireImage4;
    public GameObject fireImage5;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes * 60; // having it in seconds
        gameOver.SetActive(false);
        fireImage1.SetActive(false);
        fireImage2.SetActive(false);
        fireImage3.SetActive(false);
        fireImage4.SetActive(false);
        fireImage5.SetActive(false);
            }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime - Time.deltaTime;
        
        if (currentTime >= 150 || currentTime <= 120)
        {
            fireImage2.SetActive(true);
        }

        if (currentTime >= 120 || currentTime <= 90)
        {
            fireImage2.SetActive(true);
        }
        if (currentTime >= 90 || currentTime <= 60)
        {
            fireImage3.SetActive(true);
        }

        if (currentTime >= 60 || currentTime <=  30)
        {
            fireImage4.SetActive(true);
        }
        if (currentTime >= 30 || currentTime <= 0)
        {
            fireImage5.SetActive(true);
        }


        if (currentTime <= 0)
        {
            currentTime = 0;
            gameOver.SetActive(true);
        }
       
        TimeSpan time = TimeSpan.FromSeconds(currentTime); //convert seconds into minutes
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
        //currentTimeText.text = currentTime.ToString();
    }

    /*void Fire()
    {
        if (currentTime >= 30 || currentTime <=  60)
        {
            fireImage1.SetActive(true);
        }
    } */



    // else if (currentTime )
}


