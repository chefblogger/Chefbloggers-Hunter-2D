using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

private void OnGUI()
    {
        GUI.skin.button.fontSize = 30;
        //GUI.Button(new Rect(0, 0, 600, 100), "Menu");
       if (GUI.Button (new Rect (Screen.width - 200,Screen.height - 100,200,100), "Menu")) {
           SceneManager.LoadScene(0); 
       }

       if (GUI.Button (new Rect (Screen.width - 200,Screen.height - 700,200,100), "Pause")) {
           //SceneManager.LoadScene(0); 
           //Debug.Log("pause");
           Time.timeScale = 0f;
       }

       if (GUI.Button (new Rect (Screen.width - 200,Screen.height - 600,200,100), "Resume")) {
           //SceneManager.LoadScene(0); 
           //Debug.Log("weiter");
           Time.timeScale = 1f;
       }

        
    }



}
