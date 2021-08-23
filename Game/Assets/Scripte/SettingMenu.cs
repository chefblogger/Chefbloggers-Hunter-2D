using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingMenu : MonoBehaviour
{

string left ="left";
string right ="right";

 public void JoystickLeft(){
     
     PlayerPrefs.SetInt("jsSetting", 1 );
     SceneManager.LoadScene("StartMenu");  
 }

  public void JoystickRight(){
     PlayerPrefs.SetInt("jsSetting", 2 );
     SceneManager.LoadScene("StartMenu");  
 }



}
