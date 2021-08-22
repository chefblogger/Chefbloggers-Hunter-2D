using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempLevelData : MonoBehaviour
{

    public static int LevelNr = 0;
    public int LevelNummer = 0;

    private int LevelOldScore;
    private int TempCashPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
       PlayerPrefs.SetInt("LevelNummer", LevelNummer);

       //startData.score = PlayerPrefs.GetInt("tempCoin");

       PlayerPrefs.SetInt("TempCashPoints", 0);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
