using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlayer : MonoBehaviour 
 {
    [SerializeField]
    private AudioClip mySound;

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log($"Trigger Enter Called {collider.transform.tag}");
        if (collider.transform.CompareTag("Player"))
        {

            AudioSource.PlayClipAtPoint(mySound, transform.position);
            
        }
        //mySound.Play();
    }
}

