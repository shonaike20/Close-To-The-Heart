using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickURL : MonoBehaviour
{  
   
    public string url;

    public void Open()
    {
        Debug.Log("Open URL Click");

       Application.OpenURL("https://www.iheart.com/music-festival/");
    }
}
