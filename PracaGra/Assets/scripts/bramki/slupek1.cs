using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slupek1 : MonoBehaviour
{
    private bool test = false;
    public GameObject g;
    public otwarcieklucze test1;
    public Image sp2;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            g.SetActive(true);
            test1.SendMessage("SetAsReadyToUse");
            sp2.color = Color.clear;
        }
    }
    public void SetAsReadyToUse()
    {
        test = true;
    }

}