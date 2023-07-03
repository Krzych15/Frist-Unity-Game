using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class testkulka : MonoBehaviour
{
    public testaktywacji ea;
    public Image sp;
   // public EquipmentActivation ea;

    private void OnTriggerEnter(Collider other)
    {
       ea.SendMessage("SetAsReadyToUse");
        Destroy(this.gameObject);
        sp.color = Color.white;
    }
}
