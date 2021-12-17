using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    static public int playerScore = 0; // lygio score
    static public int coinsInGame = 0;
    static public int gameScore; // zaidimo iki mirties score


    static public void scoreIs()
    {
        Debug.Log("Score is: " + playerScore);
    }
    static public void coinsAre()
    {
        Debug.Log("Coins are: " + coinsInGame);
    }

}
