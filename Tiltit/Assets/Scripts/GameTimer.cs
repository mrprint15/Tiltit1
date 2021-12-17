using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

 public class GameTimer : MonoBehaviour
{
    static public float time = 0;
    static public bool timerIsRunning = false;
    public Text timeText;

    private void Start()
    {
        timerIsRunning = true;
    }

    public void Update()
    {
        
        if (timerIsRunning)
        {         
            time += Time.deltaTime;
            DisplayTime(time);
        }
           else
            {
                timerIsRunning = false;
                 time = 0;
            }
      
    }

    static public void scoreTimeAdd() //atima sugaista laika nuo surinkto score jeigu galutinis score nesigauna maziau 0
    {
        if (Score.playerScore > (Convert.ToInt32(time) / 5))
            Score.playerScore = Score.playerScore - (Convert.ToInt32(time) / 5);
        else Score.playerScore = 0;
    }

    public void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}