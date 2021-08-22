using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreboard : MonoBehaviour
{


public int portalOeffnen = 0;
public int AnzahlCoins = 0;

public GameObject portal;

private int TempCashPoints;
private int CashPoints;
private int TotalCash;

private int FreeCoins;



    private void OnGUI()
    {

        TempCashPoints = PlayerPrefs.GetInt("TempCashPoints");
        CashPoints = PlayerPrefs.GetInt("CashPoints");

        TotalCash = TempCashPoints + CashPoints;

        FreeCoins = AnzahlCoins - TempCashPoints;

        GUI.skin.box.fontSize = 50;
        //GUI.Box(new Rect(0, 0, 600, 100), "Score: " + startData.score + " Points");

        GUI.Box(new Rect(0, 0, 400, 80), "Score: " +  TotalCash);
        GUI.Box(new Rect(410, 0, 400, 80), PlayerPrefs.GetInt("lifepoint") + " Reincarnations");
        GUI.Box(new Rect(820, 0, 400, 80), "Free Coins: " + FreeCoins);
        


        //GUI.Box(new Rect(0, 250, 600, 100), "TempPoints: " + PlayerPrefs.GetInt("TempCashPoints"));
        //GUI.Box(new Rect(0, 350, 600, 100), "echte punkte: " + PlayerPrefs.GetInt("CashPoints"));
        
        

        if (TotalCash >= portalOeffnen){
            //Debug.Log("Gewonnen");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            //portal aktivieren
            portal.SetActive(true);
            
        }

        
    }


}
