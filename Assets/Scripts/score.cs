using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is necessary for UI elements
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
