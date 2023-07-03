using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slupek2 : MonoBehaviour
{
    private bool test = false;
    public GameObject g;
    public otwarcieklucze test2;
    public Image sp3;


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            g.SetActive(true);
            test2.SendMessage("SetAsReadyToUse");
            sp3.color = Color.clear;
        }

    }
    public void SetAsReadyToUse()
    {
        test = true;
    }
   

}