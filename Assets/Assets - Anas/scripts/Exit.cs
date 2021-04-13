using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;


public class Exit : MonoBehaviour
{
    public RectTransform loosePanel;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            UnityEngine.Debug.Log("dead");
            loosePanel.gameObject.SetActive(true);
            // Application.Quit();
            // UnityEditor.EditorApplication.ExitPlaymode();
        }




    }
    public void Restart(){

      SceneManager.LoadScene("Assets/Assets - Anas/Scenes/SampleScene.unity");

    }
    
}
