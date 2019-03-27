using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwBall : MonoBehaviour
{

    public Rigidbody rigidBall;
    public Vector2 startTouch;
    public Vector2 endTouch;
    public float xDistance;
    public float yDistance;
    public float xForce;
    public float yForce;
    public float zForce;


    // change
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the touchCount is greater than 0, the device detects a touch ouccured
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // touch phases are began, moved, ended, cancelled, stationary
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    rigidBall.useGravity = true;
                    // sets the start of the touch to the current touch position
                    startTouch = touch.position;
                    // used for debugging
                   // Debug.Log(startTouch);
                    break;

                case TouchPhase.Ended:
                    // sets the end of the touch to the last touched position
                    endTouch = touch.position;
                  //  Debug.Log(endTouch);
                    break;

            }

            // touch range goes from 0 to 266 on my phone
            // need to fix code so bigger than 

            xDistance = endTouch.x - startTouch.x;
            yDistance = startTouch.y - endTouch.x;
          

            Debug.Log("StartTouchX : " + startTouch.x); 
            Debug.Log("EndTouchX: " + endTouch.x);

            // script for showing screen width.
            Debug.Log("Screen Width : " + Screen.width);


            if (startTouch.x > endTouch.x)
                xForce = xDistance * -0.1f;
            if (startTouch.x < endTouch.x)
                xForce = xDistance * 0.1f;

            yForce = yDistance * 0.1f;
            zForce = yForce * 1.5f;

            rigidBall.AddForce(xForce, yForce, zForce);

        }

    }
}
