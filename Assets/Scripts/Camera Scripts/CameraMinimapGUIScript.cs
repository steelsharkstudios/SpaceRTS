using UnityEngine;
using System.Collections;

public class CameraMinimapGUIScript : MonoBehaviour {  

	public GameObject minimapCameraObject;

	public GUISkin minimapSkin;

	private Camera minimapCamera;
	
	// Use this for initialization
	void Start () {
		
		if (minimapCameraObject != null)
			minimapCamera = minimapCameraObject.GetComponent<Camera>();
	}
	
	void OnGUI() {

		if (minimapSkin)
			GUI.skin = minimapSkin;

		GUI.Box(new Rect(minimapCamera.pixelRect.x, (Screen.height - minimapCamera.pixelRect.yMax), 
		             minimapCamera.pixelWidth, minimapCamera.pixelHeight), "");
	}
}