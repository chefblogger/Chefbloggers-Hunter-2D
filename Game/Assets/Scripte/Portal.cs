using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

private int oldCoins;
private int CashPoints;
private int TotalPoints;
    private void Start()
    {
        gameObject.SetActive(false);
    }

private void OnCollisionEnter2D(Collision2D collision)
     {
        if (collision.transform.tag == "Player")
        {

         //temp geld zu vermögen
        oldCoins = PlayerPrefs.GetInt("TempCashPoints");
        CashPoints = PlayerPrefs.GetInt("CashPoints");
        TotalPoints = oldCoins + CashPoints;

        PlayerPrefs.SetInt("CashPoints", TotalPoints );

            
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 

        }

    }

}
