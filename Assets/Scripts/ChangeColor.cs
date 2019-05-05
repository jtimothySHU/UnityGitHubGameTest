using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    static public int colorChoice;
    public Text colorSelectionTextTitle;
    public string colorText;

    // on click
    public void ChangeTheColor(int thisColor)
    {
        colorChoice = thisColor;   
    }

    public void ChangeTheText(string myColor)
    {
        colorText = myColor;
        colorSelectionTextTitle.text = colorText;

    }


}
