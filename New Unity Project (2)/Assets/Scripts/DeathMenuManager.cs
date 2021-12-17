using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenuManager : MonoBehaviour
{
    private GameData gameData;

    public Text uiCoins;
    public Text hScore;
    public Text scoreIs;

    private void Awake()
    {
        gameData = SaveSystem.Load();
        RefreshUi();
    }

    void RefreshUi()
    {
        uiCoins.text = gameData.totalCoins.ToString();
        hScore.text = gameData.HighScore.ToString();
        scoreIs.text = Score.gameScore.ToString();
    }

}
