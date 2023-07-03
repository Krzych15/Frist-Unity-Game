using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koniec : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.name == "Erika")
        {
            Debug.Log("dotarles do celu");
            coll.gameObject.GetComponent<ermove>().enabled = false;
            coll.gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
