using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int totalCoins;
    public int HighScore;

    public GameData()
    {
        totalCoins = 0;
        HighScore = 0;
    }
}
