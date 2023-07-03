using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]
public class karnister : MonoBehaviour
{
    public aktywacja ekw;
    public Image sprite;
    public AudioClip clip;
    private void OnTriggerEnter(Collider other)
    {
        ekw.SendMessage("SetAsReadyToUse");
        Destroy(this.gameObject);
        sprite.color = Color.white;
     
        if(clip!=null)
        {
            AudioSource.PlayClipAtPoint(clip, this.gameObject.transform.position);
        }
    }
}
