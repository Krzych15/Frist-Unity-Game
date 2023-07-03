using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class klucz3: MonoBehaviour
{
    public slupek2 slupek2;
    public Image sp3;
    

    private void OnTriggerEnter(Collider other)
    {
        slupek2.SendMessage("SetAsReadyToUse");
        Destroy(this.gameObject);
        sp3.color = Color.white;
    }
}