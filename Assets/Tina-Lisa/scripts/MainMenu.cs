using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace tisa
{
    public class MainMenu : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene("Assets/Tina-Lisa/Game/Scenes/Lvl 1 Recycling.unity");
        }

        public void ExitGame()
        {
            SceneManager.LoadScene(0);
            // #if UNITY_EDITOR 
            // UnityEditor.EditorApplication.ExitPlaymode();
            // #endif
        }
    }
    
}
