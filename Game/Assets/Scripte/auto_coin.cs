using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_coin : MonoBehaviour
{


    public GameObject prefab;
    public int num = 10;
    public float xachse = 8;
    public float yachse = 5;





   private void Start()
   {
       spawnTarget();
   } 

   public void spawnTarget(){

    for (int i = 0; i < num; i++)
        {
        Debug.Log("target generiert");
        Vector3 position = new Vector3(Random.Range(-xachse, xachse), Random.Range(-yachse, yachse), 0);
        Instantiate(prefab, position, Quaternion.identity);

        }

       
   }
   
}
