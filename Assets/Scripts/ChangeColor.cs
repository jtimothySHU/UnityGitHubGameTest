using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public static Material ballColor;

    // Update is called once per frame
    public void ChangeTheColor(Material thisColor)
    {
        ballColor = thisColor;
    }
}
