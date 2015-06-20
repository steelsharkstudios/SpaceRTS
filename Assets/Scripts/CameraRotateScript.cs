using UnityEngine;
using System.Collections;

public class CameraRotateScript : MonoBehaviour {

	public float rotateTime = 0.3f;
	public float degreeRotation = 90.0f;

	private bool rotationInProgress = false;
	
	// Update is called once per frame
	void Update () {

		// Don't allow input while rotation is in progress
		if (rotationInProgress)
			return;

		// Controls
		if (Input.GetButtonDown("Rotate Left"))
			StartCoroutine("Rotate", true);
		if (Input.GetButtonDown("Rotate Right"))
			StartCoroutine("Rotate", false);
	}

	// Rotates camera based on public variables
	IEnumerator Rotate(bool turningLeft) {

		rotationInProgress = true;

		Quaternion startRotation = transform.rotation;
		Quaternion endRotation = transform.rotation ;

		if (turningLeft)
			endRotation *= Quaternion.Euler(0, degreeRotation, 0);
		else
			endRotation *= Quaternion.Euler(0, -degreeRotation, 0);

		float time = 0f;
		float rate = 1.0f / rotateTime;

		while (time < 1.0f) {
			
			time += Time.deltaTime * rate;
			transform.rotation = Quaternion.Slerp(startRotation, endRotation, time);
			yield return null;
		}

		rotationInProgress = false;
	}
}