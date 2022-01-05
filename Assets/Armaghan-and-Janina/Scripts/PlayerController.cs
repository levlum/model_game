using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;


public class PlayerController : MonoBehaviour
{
    public Transform teleportDestination_Level2;
    public Transform teleportDestination_Level1;

    public Light JaninaLightMain;
    public Light JaninaLightLeft;
    public Light JaninaLightRight;

    public GameObject RightParticle;
    public GameObject LeftParticle;

    public GameObject LevelLeftOn;
    public GameObject LevelLeftOff;
    public GameObject LevelRightOn;
    public GameObject LevelRightOff;

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;

    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;

    public AudioClip PassedRing;
    public AudioClip FinalRing;
    public AudioClip Teleport;

    //private color BlueColor;


    //Teleport the Player into another Level by Colliding with a specific Object
    private void OnTriggerEnter(Collider other) //if the Playersphere collides with another object
    {
        if (other.gameObject.CompareTag("Teleport")) //and the other object has the tag "Teleport"
        {
            gameObject.transform.position = teleportDestination_Level2.position; //set the position of the Player to the position of the Destination-Object (Level2)
            AudioSource.PlayClipAtPoint(Teleport, transform.position, 300);
            //JaninaLightMain.SetActive(false);
            Light1.SetActive(true);
        }

        if (other.gameObject.CompareTag("Teleport_Outside")) //if it collides with another object that has the tag "Teleport_Outside"
        {
            AudioSource.PlayClipAtPoint(Teleport, transform.position, 50);
            gameObject.transform.position = teleportDestination_Level1.position; //set the position of the Player to the position of the Destination-Object (Level1)
            //JaninaLightMain.SetActive(true);
            Light1.SetActive(false);
        }
        
        //Light Switching And Audio Playing Codes
        if (other.gameObject.CompareTag("Level1"))
        {
            Level1.SetActive(false);
            Level2.SetActive(true);
            Level3.SetActive(true);
            Level4.SetActive(true);
            Light1.SetActive(true);
            Light2.SetActive(true);
            Light3.SetActive(false);
            Light4.SetActive(false);
            Light5.SetActive(false);
            //AudioSource.PlayClipAtPoint(PassedRing, transform.position, 1.5f);
            //Cposition = new Vector3(0.0f,24.0f,-36.0f);
            UnityEngine.Debug.Log("Level1");
        }
        if (other.gameObject.CompareTag("Level2"))
        {
            Level1.SetActive(true);
            Level2.SetActive(false);
            Level3.SetActive(true);
            Level4.SetActive(true);
            Light1.SetActive(false);
            Light2.SetActive(true);
            Light3.SetActive(true);
            Light4.SetActive(false);
            Light5.SetActive(false);
            //AudioSource.PlayClipAtPoint(PassedRing, transform.position, 1.5f);
            //Cposition = new Vector3(0.0f,40.0f,-36.0f);
        }
        if (other.gameObject.CompareTag("Level3"))
        {
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(false);
            Level4.SetActive(true);
            Light1.SetActive(false);
            Light2.SetActive(false);
            Light3.SetActive(true);
            Light4.SetActive(true);
            Light5.SetActive(false);
            //AudioSource.PlayClipAtPoint(PassedRing, transform.position, 1.5f);
            //Cposition = new Vector3(0.0f,56.0f,-36.0f);
        }
        if (other.gameObject.CompareTag("Level4"))
        {
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(true);
            Level4.SetActive(false);
            Light1.SetActive(false);
            Light2.SetActive(false);
            Light3.SetActive(false);
            Light4.SetActive(true);
            Light5.SetActive(true);
            //DirectionalLight.SetActive(true);
            //AudioSource.PlayClipAtPoint(FinalRing, transform.position, 1.5f);
            //Cposition = new Vector3(0.0f,56.0f,-36.0f);
        }
        if (other.gameObject.CompareTag("Level Left"))
        {
            JaninaLightLeft.color = Color.blue;
            LeftParticle.SetActive(true);
            //JaninaLightMain.SetActive(false);
            //JaninaLightRight.SetActive(false);
            LevelLeftOn.SetActive(false);
            LevelLeftOff.SetActive(true);
            LevelRightOn.SetActive(true);
            LevelRightOff.SetActive(false);
        }
        if (other.gameObject.CompareTag("Level Right"))
        {
            //JaninaLightLeft.SetActive(false);
            //JaninaLightMain.SetActive(false);
            JaninaLightRight.color = Color.blue;
            RightParticle.SetActive(true);
            LevelLeftOn.SetActive(true);
            LevelLeftOff.SetActive(false);
            LevelRightOn.SetActive(false);
            LevelRightOff.SetActive(true);
        }
        if (other.gameObject.CompareTag("Level Main"))
        {
            //JaninaLightLeft.SetActive(false);
            JaninaLightMain.color = Color.blue;
            //JaninaLightRight.SetActive(false);
            LevelLeftOn.SetActive(true);
            LevelLeftOff.SetActive(false);
            LevelRightOn.SetActive(true);
            LevelRightOff.SetActive(false);
        }

        if (other.gameObject.CompareTag("RightMainWall"))
        {
            
        }
    }

}



