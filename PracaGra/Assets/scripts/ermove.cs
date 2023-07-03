using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ermove : MonoBehaviour
{
   
    Animator animator,bieg,wslizg,atak;
    
    public float rotation;
    public GameObject strzala;
    public Transform naciaganie;

    void Start()
    {
        animator = GetComponent<Animator>();
        bieg = GetComponent<Animator>();
        wslizg = GetComponent<Animator>();
        atak = GetComponent<Animator>();
        
    }

    void Update()
    {
        bool forwardkey = Input.GetKey(KeyCode.W);
        animator.SetBool("forward", forwardkey);

        bool leftKey = Input.GetKey(KeyCode.A);
        bool rightKey = Input.GetKey(KeyCode.D);
        bool shiftkey = Input.GetKey(KeyCode.LeftShift);
         bieg.SetBool("run", shiftkey);

        bool ctrlkey = Input.GetKey(KeyCode.LeftControl);
        wslizg.SetBool("wslizg", ctrlkey);

        bool fight = Input.GetKey(KeyCode.Mouse0);
        atak.SetBool("atak", fight);
        if (Input.GetKeyDown(KeyCode.Mouse0) )
        {
           
            Debug.Log("fire");

        Instantiate(strzala, naciaganie.position, naciaganie.rotation);
    }  

        if (leftKey)
        {
            gameObject.transform.Rotate(0f, -rotation, 0f);
        }
        if (rightKey)
        {
            gameObject.transform.Rotate(0f, rotation, 0f);
        }
    }
}
