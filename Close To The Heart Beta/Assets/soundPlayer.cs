using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class soundPlayer : MonoBehaviour 
 {

   
    AudioSource mySound;


    void Start()
    {
        mySound = GetComponent<AudioSource>();
        //Fetch the AudioSource from the GameObject


    }
    //private bool _playing = false;
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log($"Trigger Enter Called {collider.transform.tag}");
        if (collider.transform.CompareTag("Player"))
        {
            
            if ( !mySound.isPlaying )
            {
                mySound.Play();
                Debug.Log("Playing");
               //_playing = true;
            }
            else
            {
                mySound.Stop();
                Debug.Log("Stopping");
                 //_playing = false;
            }  
        }
    }
}

