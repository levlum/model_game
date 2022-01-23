using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class buttonrestart : MonoBehaviour
{
    
    
    public void ResetScene()
    {

        SceneManager.LoadScene("6.0 Bubblegame");

    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
