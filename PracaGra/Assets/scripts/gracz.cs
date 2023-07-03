using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gracz : MonoBehaviour
{
    public GameObject player;
   
    public static gracz instance;

     void Awake()
    {
        instance = this;   
    }
    
}
