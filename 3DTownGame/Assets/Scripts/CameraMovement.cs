using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float cameraMovementSpeed = 2f;
	
	// Update is called once per frame
	void Update () {

		Vector3 mouseOffset = new Vector3(-Input.GetAxis("Mouse Y") * cameraMovementSpeed, Input.GetAxis("Mouse X") * cameraMovementSpeed, 0f);
		GetComponent<Camera>().transform.Rotate(mouseOffset, Space.Self);
		//auto-up the lazy way:
		GetComponent<Camera>().transform.LookAt(
			GetComponent<Camera>().transform.position + GetComponent<Camera>().transform.forward, 
			Vector3.up);


	}
}
