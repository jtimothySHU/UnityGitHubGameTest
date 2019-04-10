using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    public UnityEngine.UI.Text text;

    public GameObject theBall;

    public int count;
    public int total;

    public Vector3 startingPoint = new Vector3(0f, 3.904f, -45f);

    private void Start()
    {
        //Look buddy, I don't care about 'traditional' naming
        //conventions
        text.text = "Score: " + count.ToString();
        total = 0;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            //Destroy(col.gameObject);
            theBall.transform.position = startingPoint;
            total += count;
            text.text = "Score: " + count.ToString();
        }
    }
}
