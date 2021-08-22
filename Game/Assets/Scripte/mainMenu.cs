using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{


private int levelID = 0;

 public void PlayGame(){
    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    SceneManager.LoadScene("Level1");     

 }

 public void QuitGame(){
     Application.Quit();
 }

public void ManualGame(){
     SceneManager.LoadScene("StartManual"); 
 }

 public void BackGame(){
     SceneManager.LoadScene("StartMenu");  
 }

 public void PlayAgainGame(){
     levelID = PlayerPrefs.GetInt("LevelNummer");
     SceneManager.LoadScene(levelID);  
 }

public void ResetGame(){
     PlayerPrefs.SetInt("highscore", 0);
     SceneManager.LoadScene("StartMenu");  
 }
 
}
