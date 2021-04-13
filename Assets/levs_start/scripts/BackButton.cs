using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lev
{
   
    public class BackButton : MonoBehaviour
    {
        public void LoadFirstScene(){
            Debug.Log("LoadScene(0)");
            SceneManager.LoadScene(0);
        }
    }
}