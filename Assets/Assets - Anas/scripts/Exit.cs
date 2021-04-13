using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;


public class Exit : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            UnityEngine.Debug.Log("dead");
            SceneManager.LoadScene(0);
            // Application.Quit();
            // UnityEditor.EditorApplication.ExitPlaymode();
        }




    }
    
    
}
