using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otwarcieklucze : MonoBehaviour
{
    private bool test1 = false;
   private bool test2 = false;
    public GameObject open;
    public GameObject open2;
    

    private void OnTriggerStay(Collider other)
    {
            if (Input.GetKeyDown(KeyCode.B) && (test1 == true) && (test2 == true))
            { 
                open.transform.Rotate(0, 50, 0);
                open2.transform.Rotate(0, -50, 0);
            }
       
        

        }
            
    
        public void SetAsReadyToUse()
        {
            test1 = true;
            test2 = true;
        }
    }