using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    public UnityEngine.UI.Text text;

    public GameObject theBall;

    public int count;
    public int total;

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
            theBall.transform.Translate(0f, 3.904f, -45);
            total += count;
            text.text = "Score: " + count.ToString();
        }
    }
}
