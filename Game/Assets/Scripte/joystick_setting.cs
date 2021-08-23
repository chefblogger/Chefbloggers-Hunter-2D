using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick_setting : MonoBehaviour
{

    private int jsSetting;
    public GameObject JoystickLinks;
    public GameObject JoystickRechts;
    // Start is called before the first frame update


    void Start()
    {
        jsSetting = PlayerPrefs.GetInt("jsSetting");

        if (jsSetting == 1)
        {
            JoystickLinks.SetActive(true);
            JoystickRechts.SetActive(false);
        }
        else if  (jsSetting == 2)
        {
            JoystickLinks.SetActive(false);
        JoystickRechts.SetActive(true);
        }

    }
    

 
}
