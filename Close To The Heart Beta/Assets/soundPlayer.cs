using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlayer : MonoBehaviour 
 {
    [SerializeField]
    private AudioClip mySound;

    private bool _playing = false;
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log($"Trigger Enter Called {collider.transform.tag}");
        if (collider.transform.CompareTag("Player"))
        {
            if( !_playing )
            {
                AudioSource.PlayClipAtPoint(mySound, transform.position);
                _playing = true;
            }
            else
            {
                mySound.Stop(); 
                 _playing = false;
            }  
        }
    }
}

