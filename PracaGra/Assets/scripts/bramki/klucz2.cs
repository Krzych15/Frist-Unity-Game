using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class klucz2 : MonoBehaviour
{
    public slupek1 kulka2;
    public Image sp2;
   

    private void OnTriggerEnter(Collider other)
    {
        kulka2.SendMessage("SetAsReadyToUse");
        Destroy(this.gameObject);
        sp2.color = Color.white;
    }
}