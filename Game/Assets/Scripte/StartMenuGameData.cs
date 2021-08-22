using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuGameData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //wieviele leben hat der user?
        PlayerPrefs.SetInt("lifepoint", 3);
        
        PlayerPrefs.SetInt("CashPoints", 0);
        PlayerPrefs.SetInt("TempCashPoints", 0);



        startData.score = 10;
        PlayerPrefs.SetInt("LevelOldScore", 0);

        //highscore ausschalten
        //PlayerPrefs.SetInt("highscore", 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
