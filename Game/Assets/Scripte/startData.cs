using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startData : MonoBehaviour
{

    public static int score = 0;
    public static int lifepoint = 3;

   private int LevelOldScore;

    public static string CurrentLevel = "Startmenu";
   

    
    // Start is called before the first frame update
    void Start()
    {
       //score
       score = 0;

    
        lifepoint = PlayerPrefs.GetInt("lifepoint");



        LevelOldScore = PlayerPrefs.GetInt("LevelOldScore");
        PlayerPrefs.SetInt("temppoints", LevelOldScore);
        
        
       //lifepoint = 3;
        

    }


}
