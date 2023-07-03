using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class strzelanie : MonoBehaviour
{
    public GameObject strzala;
    public Transform naciaganie;

    

    void Update()
    {
        /*  if (Input.GetKeyDown(KeyCode.Mouse0) && (t == true))
         {
             */
        
        if (Input.GetKeyDown(KeyCode.Mouse0)){

    
                Debug.Log("fire");

                Instantiate(strzala, naciaganie.position, naciaganie.rotation);
            }
            
        }
       
    }
   

