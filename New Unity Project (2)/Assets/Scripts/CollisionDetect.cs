using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("coin"))
        {
            Destroy(coll.gameObject);
            scoreAdd();
            coinsAdd();

           
            


            Score.scoreIs(); // debug.log
            Score.coinsAre();
        }
    }
    public void scoreAdd()
    {
        Score.playerScore = Score.playerScore + 10;
        
    }
    public void coinsAdd()
    {
        Score.coinsInGame = Score.coinsInGame + 10;
    }

}
