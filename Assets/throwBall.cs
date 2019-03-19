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
    const float XFORCE = 4;


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
                    Debug.Log(startTouch);
                    break;

                case TouchPhase.Ended:
                    // sets the end of the touch to the last touched position
                    endTouch = touch.position;
                    Debug.Log(endTouch);
                    break;

            }

            xDistance = endTouch.x - startTouch.x;
            Debug.Log(" space ");
            Debug.Log(xDistance);
            yDistance = endTouch.y - endTouch.x;

            rigidBall.AddForce(0, yDistance * 0.5f, XFORCE);

        }

    }
}
