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
    public float xForce = 0;
    public float yForce = 0;
    public float zForce = 0;
    public float touchTimeStart, touchTimeFinish, timeInterval; // to calculate swipe time



    // change
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if you touch the screen
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {

            // getting touch position and marking time when you touch the screen
            touchTimeStart = Time.time;
            startTouch = Input.GetTouch(0).position;
        }


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {

            // marking time when you release it
            touchTimeFinish = Time.time;

            // calculate swipe time interval 
            timeInterval = touchTimeFinish - touchTimeStart;

            // getting release finger position
            endTouch = Input.GetTouch(0).position;

            xDistance = endTouch.x - startTouch.x;
            yDistance = endTouch.y - startTouch.y;


            //Debug.Log("StartTouchX : " + startTouch.x);
            //Debug.Log("EndTouchX: " + endTouch.x);

            // script for showing screen width.
            //Debug.Log("Screen Width : " + Screen.width);
            // Debug.Log("Screen Height: " + Screen.height);

            yForce = yDistance * 0.3f;
            zForce = yForce * 3.5f;
            xForce = xDistance * 0.5f;


            // original code
            /*
            if (startTouch.x >= endTouch.x)
                xForce = xDistance * -0.2f;
            if (startTouch.x < endTouch.x)
                xForce = xDistance * 0.2f;
                */


            /*
            rigidBall.AddForce(xForce, yForce, zForce / timeInterval);
            */

            if (startTouch.x >= endTouch.x)
            {
                //rigidBall.AddForce(xForce, yForce, zForce / timeInterval);
                //rigidBall.AddForce(Vector3.left);
                rigidBall.velocity = new Vector3(xForce * 0.5f, yForce * 0.2f, zForce);
                
                //rigidBall.velocity.x
                Debug.Log("going left" + -xForce);
                Debug.Log("xDistance: " + xDistance);
            }
            if (startTouch.x < endTouch.x)
            {
                rigidBall.AddForce(xForce, yForce, zForce / timeInterval);
                Debug.Log("going right");
                Debug.Log("xDistance: " + xDistance);

            }


        }

    }


}
