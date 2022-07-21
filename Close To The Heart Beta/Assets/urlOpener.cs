
using UnityEngine;

public class urlOpener : MonoBehaviour
{
	public string url;
	
	public void Open()
	{
		Application.OpenURL(url);
	}
}
