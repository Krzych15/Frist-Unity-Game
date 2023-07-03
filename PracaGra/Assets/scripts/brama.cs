using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brama : MonoBehaviour
{
    
    public GameObject dl;
    public GameObject dp;
    
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.O) )
        {
            dl.transform.Rotate(0, 20, 0);
            
        }
    }
}
