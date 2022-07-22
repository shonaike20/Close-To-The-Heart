using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonURL : MonoBehaviour
{
    public string url;
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log($"Trigger Enter Called {collider.transform.tag}");
        if (collider.transform.CompareTag("Player"))
        {
            Debug.Log("Open URL Click");

            Application.OpenURL(url);

        }
    }
}
