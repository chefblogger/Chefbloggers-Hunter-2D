using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPlayer : MonoBehaviour
{

private int oldCoins;
private int newCoins;

private int CashPoints;
private int TotalPoints;

    public ParticleSystem particleExplosion;

    private int Lebenspunkte = 0;
    private int TempPoint = 0;

    //private void OnCollisionEnter(Collision collision)
    //private void OnTriggerEnter2D(Collider2D collision)
    private void OnCollisionEnter2D(Collision2D collision)
     {
        if (collision.transform.tag == "Player")
        {
            Bumm();
            //objekt zerstören
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);

            //Destroy(gameObject);
            Debug.Log("wand getroffen");


            //gameObject.SetActive(false);





            //highscore in zwischenspeicher
            PlayerPrefs.SetInt("TempScore", startData.score);



            oldCoins = PlayerPrefs.GetInt("temppoints");
            newCoins = oldCoins + 1;
            PlayerPrefs.SetInt("temppoints", newCoins );

            
             oldCoins = PlayerPrefs.GetInt("TempCashPoints");
            CashPoints = PlayerPrefs.GetInt("CashPoints");
            TotalPoints = oldCoins + CashPoints;

        if (TotalPoints > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", TotalPoints);
        }

            
            //neue lebenspunkte
            Lebenspunkte = PlayerPrefs.GetInt("lifepoint") - 1;   
            PlayerPrefs.SetInt("lifepoint", Lebenspunkte);


            if (Lebenspunkte <= 0)
                {
            //load death szene
            SceneManager.LoadScene("StartDeath"); 
                }
            else{
               SceneManager.LoadScene("StartLevelDeath");  
            }
        }

    }

    void Bumm(){
        particleExplosion.Play();
    }

}
