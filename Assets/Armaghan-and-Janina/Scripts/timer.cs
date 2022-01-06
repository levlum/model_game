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
    public AudioClip FireSound;
    public AudioClip GameOverSound;

    private bool IsFirePlayed;
    private bool IsGameOverPlayed;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes * 60; // having it in seconds
        gameOver.SetActive(false);
        fireImage1.SetActive(false);
        IsFirePlayed = false;
        IsGameOverPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime = currentTime - Time.deltaTime;
        }
        
        if (currentTime >= 60 || currentTime <=  30)
        {
            fireImage1.SetActive(true);
            if (!IsFirePlayed)
            {
                IsFirePlayed = true;
                AudioSource.PlayClipAtPoint(FireSound, transform.position, 1);
            }
        }
        
        if (currentTime <= 0)
        {
            //currentTime = 0;
            gameOver.SetActive(true);
            if  (!IsGameOverPlayed)
            {
                AudioSource.PlayClipAtPoint(GameOverSound, transform.position, 1);
                IsGameOverPlayed = true;
            }
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


