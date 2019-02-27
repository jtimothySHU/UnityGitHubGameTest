﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{

    public float maxObjectSpeed = 40f;

    public float flickSpeed = 0.4f;

    public string respawnName = "";
    public float howClose = 9.5f;

    float startTime, endTime, swipeDistance, swipeTime;
    Vector2 startPos;
    Vector2 endPos;
    float tempTime;

    float flickLength;
    float objectVelocity = 0;
    float objectSpeed = 0;
    Vector3 angle;

    bool thrown, holding;
    Vector3 newPosition, velocity;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().useGravity = false;
    }

    void OnTouch()
    {
        Vector3 mousePos = Input.GetTouch(0).position;                 
        mousePos.z = Camera.main.nearClipPlane * howClose;
        newPosition = Camera.main.ScreenToViewportPoint(mousePos);
        this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, newPosition, 80f * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (holding)
        {
            OnTouch();
        }
        else if (thrown)
        {
            return;
        }

        if (Input.touchCount > 0)           // if finger is on screen
        {
            Touch _touch = Input.GetTouch(0);
            if (_touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;


                if(Physics.Raycast(ray, out hit, 100f))
                {
                    if (hit.transform == this.transform)
                    {
                        startTime = Time.time;
                        startPos = _touch.position;
                        holding = true;
                        transform.SetParent(null);
                    }
                }
            } else if (_touch.phase == TouchPhase.Ended && holding)
            {
                endTime = Time.time;
                endPos = _touch.position;
                swipeDistance = (endPos - startPos).magnitude;
                swipeTime = endTime - startTime;

                if (swipeTime < flickSpeed && swipeDistance > 100f)
                {
                    CalSpeed();
                    MoveAngle();
                    this.GetComponent<Rigidbody>().AddForce(new Vector3((angle.x * objectSpeed), (angle.y * objectSpeed), (angle.z * objectSpeed)));
                    this.GetComponent<Rigidbody>().useGravity = true;
                    holding = false;
                    thrown = true;
                    Invoke("_Reset", 5f);
                }
                else
                {
                    _Reset ();
                }
            }


            if (startTime > 0)
            {
                tempTime = Time.time - startTime;
            }
            if(tempTime > flickSpeed)
            {
                startTime = Time.time;
                startPos = _touch.position;
            }
        }
    

    }



    void _Reset()
    {
        Transform ReSpawnPoint = GameObject.Find(respawnName).transform;
        this.gameObject.transform.position = ReSpawnPoint.position;
        this.gameObject.transform.rotation = ReSpawnPoint.rotation;
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        this.GetComponent<Rigidbody>().useGravity = false;
        thrown = false;
        holding = false;
    }

    void CalSpeed()
    {

    }


    void MoveAngle()
    {
        angle = Camera.main.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(endPos.y + 50f, (Camera.main.GetComponent<Camera>().nearClipPlane - howClose)));
    }
}
