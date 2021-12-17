using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
