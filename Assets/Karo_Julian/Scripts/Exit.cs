using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;


public class Exit : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UnityEngine.Debug.Log("dead");

            //Application.Quit();
            // UnityEditor.EditorApplication.ExitPlaymode();
            SceneManager.LoadScene(0);
        }




    }
    
    
}
