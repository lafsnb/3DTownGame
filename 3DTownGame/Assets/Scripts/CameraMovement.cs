using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	void Update () {

		Vector3 mouseOffset = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);
		transform.Rotate(mouseOffset, Space.Self);

		transform.LookAt(transform.position + transform.forward, Vector3.up);

	}
}
