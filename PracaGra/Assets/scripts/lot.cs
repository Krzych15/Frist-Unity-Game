using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lot : MonoBehaviour
{

    public float timer = 3f;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            transform.Translate(Vector3.forward * 0.01f);
            transform.Rotate(0, 0, 1);
        }
      
        }
    }

