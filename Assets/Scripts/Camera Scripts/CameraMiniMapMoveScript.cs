using UnityEngine;
using System.Collections;

public class CameraMiniMapMoveScript : MonoBehaviour {

	public GameObject minimapCameraObject;
	public GameObject gameCameraObject;

	private Camera minimapCamera;

	// Use this for initialization
	void Start () {
		
		if (minimapCameraObject != null)
			minimapCamera = minimapCameraObject.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {

			Vector3 mouseVector = new Vector3(Input.mousePosition.x,Input.mousePosition.y, 100.0f);
			Vector3 worldPosition = minimapCamera.ScreenToWorldPoint(mouseVector);

			worldPosition.y = gameCameraObject.transform.position.y;
			gameCameraObject.transform.position = worldPosition;
		}
	}
}