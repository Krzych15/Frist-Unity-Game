using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poruszanieczolg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward / 200);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(Vector3.back / 200);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, (float)-0.1, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, (float)0.1, 0);
        }
    }
}
