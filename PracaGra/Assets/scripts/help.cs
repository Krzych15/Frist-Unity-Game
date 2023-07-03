using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class help : MonoBehaviour
{
    public TextMeshProUGUI hint;
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        hint.enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        hint.text = text;
        hint.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        hint.enabled = false;
    }
}
