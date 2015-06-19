using UnityEngine;
using System.Collections;

public class CameraRotateScript : MonoBehaviour {
	
	public float rotationSpeed = 200;
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButton(1)) {
			
			float mouseX = Input.GetAxisRaw("Mouse X");
			float mouseY = Input.GetAxisRaw("Mouse Y");
			
			transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);
			transform.Rotate(-mouseY * rotationSpeed * Time.deltaTime, 0, 0);
		}
	}
}