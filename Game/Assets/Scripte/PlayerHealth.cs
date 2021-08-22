using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

private int oldHealth;
private int newHealth;

private void OnCollisionEnter2D(Collision2D collision)
     {
        if (collision.transform.tag == "Player")
        {
            
            //objekt zerstören
            //Destroy(collision.gameObject);
            //collision.gameObject.SetActive(false);

            
            Destroy(gameObject);
            //Debug.Log("COIND");


            //alter coin zwischenstand laden
            oldHealth = PlayerPrefs.GetInt("lifepoint");
            newHealth = oldHealth + 2;
            PlayerPrefs.SetInt("lifepoint", newHealth );
            //gameObject.SetActive(false);
 

        }

    }



}
