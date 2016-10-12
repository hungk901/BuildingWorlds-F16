using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	void Update () {

		// Zoom In
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0, .1f);
		}
		// Zoom Out
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, 0, -.1f);
		}

		// Go Left
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-.1f, 0, 0);
		}
		// Go Right
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (.1f, 0, 0);
		}	

		// Go Up
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, .1f, 0);
		}
		// Go Down
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, -.1f, 0);
		}

		// Reset
		if (Input.GetKey (KeyCode.R)) {
			transform.position = new Vector3(0, 4f, -10f);
		}
	}
}
