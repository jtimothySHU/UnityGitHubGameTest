using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    static public int colorChoice;

    // on click
    public void ChangeTheColor(int thisColor)
    {
        colorChoice = thisColor;   
    }
}
