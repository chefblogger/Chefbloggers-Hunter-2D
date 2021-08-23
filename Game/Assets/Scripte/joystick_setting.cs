using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick_setting : MonoBehaviour
{


    public GameObject JoystickLinks;
    public GameObject JoystickRechts;
    // Start is called before the first frame update
    void Start()
    {
        JoystickLinks.SetActive(true);
        JoystickRechts.SetActive(false);
    }
    

 
}
