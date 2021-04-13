using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Lev
{
   
    public class SceneLoader : MonoBehaviour
    {
        public string[] scenePaths;

        public void LoadScene(int scene_num){
            Debug.Log(scene_num);
            SceneManager.LoadScene(scenePaths[scene_num]);
        }
    }
}