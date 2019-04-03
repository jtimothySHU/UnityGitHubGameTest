using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.z);
    }
}
