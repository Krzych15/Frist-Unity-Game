using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aktywacja : MonoBehaviour
{
    private bool isReady = false;
    public GameObject go;
    public Image sprite;
    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E) && isReady)
        {
            go.SetActive(true);
            sprite.color = Color.clear;
        }
    }
    public void SetAsReadyToUse()
    {
        isReady = true;
    }
}
