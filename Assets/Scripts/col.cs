using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    public UnityEngine.UI.Text text;

    int count;

    private void Start()
    {
        //Look buddy, I don't care about 'traditional' naming
        //conventions
        count = 0;
        text.text = "Score: " + count.ToString();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            Destroy(col.gameObject);
            count += 20;
            text.text = "Score: " + count.ToString();
        }
    }
}
