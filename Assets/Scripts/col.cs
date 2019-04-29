using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    public UnityEngine.UI.Text text;

    public GameObject theBall;
    public Rigidbody rb;
   
    public int count;
    public detectionManager dm;

    public Vector3 startingPoint = new Vector3(0f, 3.904f, -45f);
    public Quaternion startingRotation = new Quaternion(0,0,0,0);

    private void Start()
    {
        /*
         * Look buddy, I don't care about 'traditional' naming
         * conventions
         */
        text.text = "Score: " + dm.score.ToString();
        dm.score = 0;
        dm.numBalls = 6;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            //Destroy(col.gameObject);
            theBall.transform.position = startingPoint;
            theBall.transform.rotation = startingRotation;
            // ballBody.velocity = Vector3.zero;
            // ballBody.Sleep();
            theBall.GetComponent<Rigidbody>().Sleep();
            Debug.Log("Count: " + count);
            dm.score += count;
            dm.numBalls -= 1;
            text.text = "Score: " + dm.score.ToString();
            Debug.Log("Number of balls: " + dm.numBalls);


            //Failure screen 
            if(dm.numBalls == 0)
            {
                Application.LoadLevel("GameOver");
            }
        }
    }
}
