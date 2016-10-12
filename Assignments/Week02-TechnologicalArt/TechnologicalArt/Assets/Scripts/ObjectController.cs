using UnityEngine;
using System.Collections;

public class ObjectController : MonoBehaviour {

	void Update () {

		// Rotate Clcokwise
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (0f, -2f, 0f); 
		}
		// Rotate Counter Clockwise
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0f, 2f, 0f);
		}

		// Reset
		if (Input.GetKey (KeyCode.R)) {
			transform.eulerAngles = new Vector3(0, 0, 0);
		}
	}
}
