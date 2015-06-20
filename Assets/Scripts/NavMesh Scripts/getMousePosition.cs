using UnityEngine;
using System.Collections;

public class getMousePosition : MonoBehaviour {
	private float xMouse;
	private float yMouse;
	private float zMouse;

	Vector3 MousePosition(){
		xMouse = Input.mousePosition.x;
		yMouse = Input.mousePosition.y;
		zMouse = Input.mousePosition.z;
		Vector3 pos = new Vector3 (xMouse, yMouse, zMouse);
		return pos;
	}
}
