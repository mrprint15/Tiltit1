using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{    
    public static int maxcoin = 0;

    void Start()
    {
        
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "Level1")
        {
            maxcoin = 30;
        }
        else if (sceneName == "Level2")
        {
            maxcoin = 40;
        }
        else if (sceneName == "Level3")
        {
            maxcoin = 80;
        }
        else if (sceneName == "Level4")
        {
            maxcoin = 90;
        }

    }
}