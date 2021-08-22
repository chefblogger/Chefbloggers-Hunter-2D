using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDeathData : MonoBehaviour
{

private int oldCoins;
private int CashPoints;
private int TotalPoints;

    // Start is called before the first frame update
    void Start()
    {
        //highscore berechnen

        


        oldCoins = PlayerPrefs.GetInt("TempCashPoints");
        CashPoints = PlayerPrefs.GetInt("CashPoints");
        TotalPoints = oldCoins + CashPoints;

        if (TotalPoints > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", TotalPoints);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
