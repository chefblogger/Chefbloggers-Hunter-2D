using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting_joystick_dp : MonoBehaviour
{

private int wert;

public TMPro.TMP_Dropdown MeineAuswahl;
public void JoystickSelector()
{
if  (MeineAuswahl.value == 0)
{
  wert = 1; 
PlayerPrefs.SetInt("Joysticksetting", wert );
}
else if  (MeineAuswahl.value == 1)
{
  wert = 2; 
PlayerPrefs.SetInt("Joysticksetting", wert );
}
}


}
