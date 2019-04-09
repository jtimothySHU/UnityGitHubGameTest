using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getColor : MonoBehaviour
{
    public GameObject theBall;
    public  Material theColor;


    public Material classicBall;
    public Material redBall;
    public Material yellowBall;
    public Material greenBall;
    public Material blueBall;
    public Material purpleBall;
    public Material griffinBall;
    public Material starsBall;
    public Material galaxyBall;

    // Start is called before the first frame update
    void Start()
    {
        switch (ChangeColor.colorChoice)
        {
            case 1:
                theColor = classicBall;
                break;
            case 2:
                theColor = redBall;
                break;
            case 3:
                theColor = yellowBall;
                break;
            case 4:
                theColor = greenBall;
                break;
            case 5:
                theColor = blueBall;
                break;
            case 6:
                theColor = purpleBall;
                break;
            case 7:
                theColor = griffinBall;
                break;
            case 8:
                    // i broke the stars ball, i'll add this once it is fixed
            case 9:
                theColor = galaxyBall;
                break;
            default:
                theColor = classicBall;
                break;
        }

        theBall.GetComponent<Renderer>().material = theColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
