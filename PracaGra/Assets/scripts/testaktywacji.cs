using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class testaktywacji : MonoBehaviour
{
    private bool test = false;
    public GameObject g;
    public GameObject open;
    public GameObject open2;
    public Image sp;
    
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.G) )
        {
            g.SetActive(true);  
            open.transform.Rotate(0, 50, 0);
            open2.transform.Rotate(0, -50, 0);
            sp.color = Color.clear;
        }
    }
        public void SetAsReadyToUse()
        {
            test = true;
        }
    
}
