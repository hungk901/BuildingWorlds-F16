using UnityEngine;
using System.Collections;

public class MouseVector : MonoBehaviour {

	public float mouseX = 0f;
	public float mouseY = 0f;
	float dirX;
	float dirZ;
	public float rotateAngle = 0f;

	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (-1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (0, 0, 1f);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (0, 0, -1f);
		}

		mouseX = Input.GetAxis ("Mouse X");	
		mouseY = Input.GetAxis ("Mouse Y");	

		rotateAngle = mouseX * 3.5f;

		transform.Rotate (0, rotateAngle, 0);

	}
}
