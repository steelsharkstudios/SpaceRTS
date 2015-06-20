using UnityEngine;
using System.Collections;

public class CameraZoomScript : MonoBehaviour {
	
	public float maxZoom = 20.0f;
	public float minZoom = 50.0f;

	public float zoomRate = 5.0f;
	
	// Update is called once per frame
	void Update () {

		float zoomDirection = Input.GetAxisRaw("Mouse ScrollWheel");

		Vector3 zoomVector = Vector3.down * zoomDirection * zoomRate;
		Vector3 newPosition = transform.position + zoomVector;
		
		newPosition.y = Mathf.Clamp(newPosition.y, maxZoom, minZoom);

		transform.position = newPosition;
	}
}