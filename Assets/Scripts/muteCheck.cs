using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class muteCheck : MonoBehaviour
{

    public static bool muteValue = false;
    public Text theSoundText;
    
    // muteValue == false Sound is on
    // muteValue == true Sound is off

    // Update is called once per frame
    void Update()
    {
        if (muteValue)
        {
            theSoundText.text = "Sound OFF";
        }

        if (!muteValue)
        {
            theSoundText.text = "Sound ON";
        }
    }

 

    public void ChangeMuteStatus()
    {

        muteValue = !muteValue;

        //Debug.Log("Mute Value is : " + muteValue);
    }
}
