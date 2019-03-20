using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followBall : MonoBehaviour
{

    public Transform player;

    public Vector3 movingOffset;
    public Vector3 FIRSTOFFSET;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.position + FIRSTOFFSET;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = player.position + movingOffset;

    }
}
