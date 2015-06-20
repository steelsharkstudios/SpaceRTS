using UnityEngine;
using System.Collections;

public class CameraMovementScript : MonoBehaviour {

	public float movementSpeed = 20;

	// Update is called once per frame
	void Update () {

		if (Input.GetButton("Up"))
			transform.Translate(0, 0, movementSpeed * Time.deltaTime);
		if (Input.GetButton("Left"))
			transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
		if (Input.GetButton("Right"))
			transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
		if (Input.GetButton("Down"))
			transform.Translate(0, 0, -movementSpeed * Time.deltaTime);
	}
}