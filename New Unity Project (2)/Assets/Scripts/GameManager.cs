using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
   
    public GameData gameData;
    private GameObject player;
    public Text Coins;

    private void Start()
    {
        Debug.Log(Score.gameScore);
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Level1")
            Score.gameScore = 0;

        GameTimer.time = 0;
        Score.playerScore = 0;
        Score.coinsInGame = 0;
        player = GameObject.Find("Player");
    }
    private void Awake()
    {
        gameData = SaveSystem.Load();
        
    }

    private void Update()
    {
        Coins.text = Score.coinsInGame.ToString();

        if (player.transform.position.y < -1.5)
        {
            Savegame();
            GameTimer.timerIsRunning = false;
            SceneManager.LoadScene("DeathMenu");
            Score.scoreIs(); // writes the score debug.log
           
        }
        if (Score.coinsInGame == FinishLevel.maxcoin)
        {   Savegame();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }


    public void Savegame()
    {
        GameTimer.scoreTimeAdd();
        Score.gameScore = Score.gameScore + Score.playerScore; // pakeicia i esama timeradd
        gameData.totalCoins += Score.coinsInGame;         // saving the high score and coins
        if (gameData.HighScore < Score.gameScore)
        gameData.HighScore = Score.gameScore;
        SaveSystem.Save(gameData);  

    }

}
