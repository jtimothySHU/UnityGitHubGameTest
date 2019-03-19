using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Dragging the "main camaera" onto the player will 'Parent' the camera to the player
    // this allows for the camera to easily track the player
    public Rigidbody rb;

    public float fowardForce = 20;
    public float sideForce = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // front and back movement 
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, fowardForce);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -1 * fowardForce);
        }

        // sideways movement

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-1 * sideForce, 0, 0);
        }


        /*
        // if touch is anywhere, then move forward
        if (Input.touchCount > 0)
        {
           // Touch touch = Input.GetTouch(0);
            rb.AddForce(0, 0, 20);
        }
        */
    }
}
