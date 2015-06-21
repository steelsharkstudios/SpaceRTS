using UnityEngine;
using System.Collections;

public class CameraMinimapGUIScript : MonoBehaviour { 

	public GameObject minimapCameraObject;

	public GUISkin minimapSkin;

	private Camera minimapCamera;

	private LineRenderer lineRenderer;
	
	// Use this for initialization
	void Start () {
		
		if (minimapCameraObject != null)
			minimapCamera = minimapCameraObject.GetComponent<Camera>();

		lineRenderer = GetComponent<LineRenderer>();
	}
	
	void OnGUI () {

		if (minimapSkin)
			GUI.skin = minimapSkin;

		Vector3 camPosition = Camera.main.transform.position;
		Vector3 viewportPosition = new Vector3(0, 0, camPosition.y);

		viewportPosition.y = Camera.main.rect.height;
		Vector3 topLeft = Camera.main.ViewportToWorldPoint(viewportPosition);

		viewportPosition.x = Camera.main.rect.width;
		viewportPosition.y = 0;
		Vector3 bottomRight = Camera.main.ViewportToWorldPoint(viewportPosition);

		Vector3 screenPoint1 = minimapCamera.WorldToScreenPoint(topLeft);
		Vector3 screenPoint2 = minimapCamera.WorldToScreenPoint(bottomRight);

		Debug.Log(screenPoint1);
		Debug.Log(screenPoint2);

		float xPos1 = screenPoint1.x;
		float yPos1 = Screen.height - screenPoint1.y;
		float xPos2 = screenPoint2.x - screenPoint1.x;
		float yPos2 = screenPoint1.y - screenPoint2.y;

		GUI.Box(new Rect(xPos1, yPos1, xPos2, yPos2), new GUIContent());

		GUI.Box(new Rect(minimapCamera.pixelRect.x, (Screen.height - minimapCamera.pixelRect.yMax), 
		                 minimapCamera.pixelWidth, minimapCamera.pixelHeight), "");
	}
}